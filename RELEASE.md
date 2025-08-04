# 自动发布指南

本项目已配置了自动发布功能，可以通过推送版本标签自动创建GitHub Releases。

## 如何创建新版本

### 方法1: 使用发布脚本 (推荐)

1. 运行发布脚本:
   ```powershell
   .\create-release.ps1 -Version "1.2.0"
   ```

2. 脚本将自动:
   - 更新 `src\WindowsAccessBridgeInterop\VersionNumber.cs` 中的版本号
   - 提交版本号更改
   - 创建版本标签 (例如: `v1.2.0`)
   - 推送标签和更改到GitHub

3. GitHub Actions 将自动:
   - 构建项目
   - 创建Release包
   - 发布到GitHub Releases

### 方法2: 手动创建标签

1. 手动更新版本号:
   - 编辑 `src\WindowsAccessBridgeInterop\VersionNumber.cs`
   - 修改 `Product` 常量的值

2. 提交更改:
   ```bash
   git add src\WindowsAccessBridgeInterop\VersionNumber.cs
   git commit -m "Bump version to 1.2.0"
   ```

3. 创建并推送标签:
   ```bash
   git tag -a v1.2.0 -m "Release version 1.2.0"
   git push origin v1.2.0
   git push origin master
   ```

## 版本号规范

- 使用语义化版本号: `主版本.次版本.修订版本` (例如: `1.2.0`)
- 标签格式: `v` + 版本号 (例如: `v1.2.0`)
- 只有推送到 `master` 分支的标签才会触发发布

## 发布内容

自动发布将包含:
- **Release构建产物**: `AccessBridgeExplorer-v1.2.0.zip`
- **发布说明**: 包含下载链接、更新内容引用和系统要求
- **自动生成的Release页面**: 在GitHub Releases中

## 监控发布状态

1. 推送标签后，访问 [GitHub Actions](../../actions) 页面
2. 查看 ".NET Framework Desktop" 工作流的运行状态
3. 构建完成后，检查 [Releases](../../releases) 页面

## 故障排除

### 常见问题

1. **构建失败**: 检查代码是否能在本地成功编译
2. **版本号冲突**: 确保标签名称是唯一的
3. **权限问题**: 确保有推送标签的权限

### 回滚发布

如果需要删除错误的发布:

1. 删除GitHub Release (在Releases页面)
2. 删除本地和远程标签:
   ```bash
   git tag -d v1.2.0
   git push origin :refs/tags/v1.2.0
   ```

## 注意事项

- 发布是自动的，一旦推送标签就会开始构建
- 确保在发布前充分测试代码
- 建议在发布前更新 `CHANGES.md` 文件
- Release构建使用Release配置，确保性能优化