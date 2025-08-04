// Copyright 2016 Google Inc. All Rights Reserved.
// Modified by husanpao - https://github.com/husanpao/access-bridge-explorer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace AccessBridgeExplorer {
  partial class AboutForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.okButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.applicationNameText = new System.Windows.Forms.TextBox();
      this.applicationCopyrightText = new System.Windows.Forms.TextBox();
      this.applicationVersionText = new System.Windows.Forms.TextBox();
      this.githubUrlLinkLabel = new System.Windows.Forms.LinkLabel();
      this.disclaimerText = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.accessBridgeLegacyText = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.accessBridgeVersionText = new System.Windows.Forms.TextBox();
      this.accessBridgePathText = new System.Windows.Forms.TextBox();
      this.accessBridgeProductText = new System.Windows.Forms.TextBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // okButton
      // 
      this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Location = new System.Drawing.Point(365, 439);
      this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(112, 32);
      this.okButton.TabIndex = 0;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.panel1.Controls.Add(this.applicationNameText);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(841, 69);
      this.panel1.TabIndex = 1;
      // 
      // applicationNameText
      // 
      this.applicationNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.applicationNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.applicationNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.applicationNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.applicationNameText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.applicationNameText.Location = new System.Drawing.Point(21, 17);
      this.applicationNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.applicationNameText.Name = "applicationNameText";
      this.applicationNameText.ReadOnly = true;
      this.applicationNameText.Size = new System.Drawing.Size(805, 38);
      this.applicationNameText.TabIndex = 0;
      this.applicationNameText.Text = "(title)";
      // 
      // applicationCopyrightText
      // 
      this.applicationCopyrightText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.applicationCopyrightText.BackColor = System.Drawing.SystemColors.Control;
      this.applicationCopyrightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.applicationCopyrightText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.applicationCopyrightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.applicationCopyrightText.Location = new System.Drawing.Point(24, 140);
      this.applicationCopyrightText.Margin = new System.Windows.Forms.Padding(0);
      this.applicationCopyrightText.Multiline = true;
      this.applicationCopyrightText.Name = "applicationCopyrightText";
      this.applicationCopyrightText.ReadOnly = true;
      this.applicationCopyrightText.Size = new System.Drawing.Size(805, 36);
      this.applicationCopyrightText.TabIndex = 4;
      this.applicationCopyrightText.Text = "(copyright)";
      // 
      // applicationVersionText
      // 
      this.applicationVersionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.applicationVersionText.BackColor = System.Drawing.SystemColors.Control;
      this.applicationVersionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.applicationVersionText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.applicationVersionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.applicationVersionText.Location = new System.Drawing.Point(24, 114);
      this.applicationVersionText.Margin = new System.Windows.Forms.Padding(0);
      this.applicationVersionText.Name = "applicationVersionText";
      this.applicationVersionText.ReadOnly = true;
      this.applicationVersionText.Size = new System.Drawing.Size(805, 19);
      this.applicationVersionText.TabIndex = 3;
      this.applicationVersionText.Text = "(version)";
      // 
      // githubUrlLinkLabel
      // 
      this.githubUrlLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.githubUrlLinkLabel.Location = new System.Drawing.Point(20, 84);
      this.githubUrlLinkLabel.Margin = new System.Windows.Forms.Padding(0);
      this.githubUrlLinkLabel.Name = "githubUrlLinkLabel";
      this.githubUrlLinkLabel.Size = new System.Drawing.Size(805, 25);
      this.githubUrlLinkLabel.TabIndex = 2;
      this.githubUrlLinkLabel.TabStop = true;
      this.githubUrlLinkLabel.Text = "https://github.com/google/access-bridge-explorer";
      this.githubUrlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubUrlLinkLabel_LinkClicked);
      // 
      // disclaimerText
      // 
      this.disclaimerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.disclaimerText.BackColor = System.Drawing.SystemColors.Control;
      this.disclaimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.disclaimerText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.disclaimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.disclaimerText.Location = new System.Drawing.Point(24, 174);
      this.disclaimerText.Margin = new System.Windows.Forms.Padding(0);
      this.disclaimerText.Name = "disclaimerText";
      this.disclaimerText.ReadOnly = true;
      this.disclaimerText.Size = new System.Drawing.Size(805, 19);
      this.disclaimerText.TabIndex = 5;
      this.disclaimerText.Text = "DISCLAIMER: This is not an official Google product.";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.accessBridgeLegacyText);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.accessBridgeVersionText);
      this.groupBox1.Controls.Add(this.accessBridgePathText);
      this.groupBox1.Controls.Add(this.accessBridgeProductText);
      this.groupBox1.Location = new System.Drawing.Point(15, 254);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(806, 143);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Java Access Bridge API details";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(4, 109);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(71, 18);
      this.label4.TabIndex = 6;
      this.label4.Text = "Legacy:";
      // 
      // accessBridgeLegacyText
      // 
      this.accessBridgeLegacyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.accessBridgeLegacyText.BackColor = System.Drawing.SystemColors.Control;
      this.accessBridgeLegacyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.accessBridgeLegacyText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.accessBridgeLegacyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accessBridgeLegacyText.Location = new System.Drawing.Point(86, 109);
      this.accessBridgeLegacyText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.accessBridgeLegacyText.Name = "accessBridgeLegacyText";
      this.accessBridgeLegacyText.ReadOnly = true;
      this.accessBridgeLegacyText.Size = new System.Drawing.Size(712, 19);
      this.accessBridgeLegacyText.TabIndex = 7;
      this.accessBridgeLegacyText.Text = "(accessbridge legacy)";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 82);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 18);
      this.label3.TabIndex = 4;
      this.label3.Text = "Version:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 54);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Product:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 26);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Path:";
      // 
      // accessBridgeVersionText
      // 
      this.accessBridgeVersionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.accessBridgeVersionText.BackColor = System.Drawing.SystemColors.Control;
      this.accessBridgeVersionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.accessBridgeVersionText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.accessBridgeVersionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accessBridgeVersionText.Location = new System.Drawing.Point(86, 82);
      this.accessBridgeVersionText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.accessBridgeVersionText.Name = "accessBridgeVersionText";
      this.accessBridgeVersionText.ReadOnly = true;
      this.accessBridgeVersionText.Size = new System.Drawing.Size(712, 19);
      this.accessBridgeVersionText.TabIndex = 5;
      this.accessBridgeVersionText.Text = "(accessbridge version)";
      // 
      // accessBridgePathText
      // 
      this.accessBridgePathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.accessBridgePathText.BackColor = System.Drawing.SystemColors.Control;
      this.accessBridgePathText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.accessBridgePathText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.accessBridgePathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accessBridgePathText.Location = new System.Drawing.Point(86, 26);
      this.accessBridgePathText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.accessBridgePathText.Name = "accessBridgePathText";
      this.accessBridgePathText.ReadOnly = true;
      this.accessBridgePathText.Size = new System.Drawing.Size(712, 19);
      this.accessBridgePathText.TabIndex = 1;
      this.accessBridgePathText.Text = "(accessbridge path)";
      // 
      // accessBridgeProductText
      // 
      this.accessBridgeProductText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.accessBridgeProductText.BackColor = System.Drawing.SystemColors.Control;
      this.accessBridgeProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.accessBridgeProductText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.accessBridgeProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accessBridgeProductText.Location = new System.Drawing.Point(86, 54);
      this.accessBridgeProductText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.accessBridgeProductText.Name = "accessBridgeProductText";
      this.accessBridgeProductText.ReadOnly = true;
      this.accessBridgeProductText.Size = new System.Drawing.Size(712, 19);
      this.accessBridgeProductText.TabIndex = 3;
      this.accessBridgeProductText.Text = "(accessbridge product)";
      // 
      // linkLabel1
      // 
      this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.linkLabel1.Location = new System.Drawing.Point(207, 208);
      this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(479, 25);
      this.linkLabel1.TabIndex = 7;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.linkLabel1.Text = "https://github.com/husanpao/access-bridge-explorer";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.BackColor = System.Drawing.SystemColors.Control;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(24, 207);
      this.textBox1.Margin = new System.Windows.Forms.Padding(0);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(185, 19);
      this.textBox1.TabIndex = 8;
      this.textBox1.Text = "Modified by husanpao:";
      // 
      // AboutForm
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(841, 483);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.disclaimerText);
      this.Controls.Add(this.githubUrlLinkLabel);
      this.Controls.Add(this.applicationVersionText);
      this.Controls.Add(this.applicationCopyrightText);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.okButton);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(838, 478);
      this.Name = "AboutForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.LinkLabel linkLabel1;

    #endregion

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox applicationNameText;
    private System.Windows.Forms.TextBox applicationCopyrightText;
    private System.Windows.Forms.TextBox applicationVersionText;
    private System.Windows.Forms.LinkLabel githubUrlLinkLabel;
    private System.Windows.Forms.TextBox disclaimerText;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox accessBridgePathText;
    private System.Windows.Forms.TextBox accessBridgeProductText;
    private System.Windows.Forms.TextBox accessBridgeVersionText;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox accessBridgeLegacyText;
  }
}