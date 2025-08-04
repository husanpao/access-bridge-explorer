# Access Bridge Explorer 发布脚本
# 此脚本用于创建版本标签并推送到GitHub，触发自动发布流程

param(
    [Parameter(Mandatory=$true)]
    [string]$Version
)

# 验证版本号格式 (例如: 1.1.0)
if ($Version -notmatch '^\d+\.\d+\.\d+$') {
    Write-Error "版本号格式无效。请使用格式: x.y.z (例如: 1.1.0)"
    exit 1
}

# 检查是否在git仓库中
if (-not (Test-Path ".git")) {
    Write-Error "当前目录不是git仓库"
    exit 1
}

# 检查工作目录是否干净
$status = git status --porcelain
if ($status) {
    Write-Warning "工作目录有未提交的更改:"
    Write-Host $status
    $continue = Read-Host "是否继续创建发布? (y/N)"
    if ($continue -ne 'y' -and $continue -ne 'Y') {
        Write-Host "发布已取消"
        exit 0
    }
}

# 更新VersionNumber.cs文件
$versionFile = "src\WindowsAccessBridgeInterop\VersionNumber.cs"
if (Test-Path $versionFile) {
    Write-Host "正在更新版本号到 $Version..."
    
    $content = Get-Content $versionFile -Raw
    $newContent = $content -replace 'public const string Product = "[^"]+";', "public const string Product = `"$Version`";"
    
    Set-Content $versionFile $newContent -NoNewline
    
    # 提交版本号更改
    git add $versionFile
    git commit -m "Bump version to $Version"
    
    Write-Host "版本号已更新并提交"
else {
    Write-Warning "未找到版本文件: $versionFile"
}

# 创建标签
$tagName = "v$Version"
Write-Host "正在创建标签: $tagName"

git tag -a $tagName -m "Release version $Version"

if ($LASTEXITCODE -ne 0) {
    Write-Error "创建标签失败"
    exit 1
}

# 推送到远程仓库
Write-Host "正在推送标签到远程仓库..."
git push origin $tagName

if ($LASTEXITCODE -ne 0) {
    Write-Error "推送标签失败"
    exit 1
}

# 同时推送主分支的更改
Write-Host "正在推送主分支更改..."
git push origin master

Write-Host ""
Write-Host "✅ 发布流程已启动!"
Write-Host "标签 '$tagName' 已创建并推送到GitHub"
Write-Host "GitHub Actions 将自动构建并创建Release"
Write-Host "请访问 https://github.com/$(git config --get remote.origin.url | sed 's/.*github.com[:\/]\([^\/]*\/[^\/]*\).*/\1/' | sed 's/\.git$//')/actions 查看构建状态"