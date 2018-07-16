﻿namespace Cliver.InvoiceParser
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.bReset = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bResetTemplates = new System.Windows.Forms.Button();
            this.IgnoreHidddenFiles = new System.Windows.Forms.CheckBox();
            this.ReadInputFolderRecursively = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bReset
            // 
            this.bReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bReset.Location = new System.Drawing.Point(142, 3);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 48;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSave.Location = new System.Drawing.Point(223, 3);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 49;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.Location = new System.Drawing.Point(304, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 50;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bSave);
            this.flowLayoutPanel1.Controls.Add(this.bReset);
            this.flowLayoutPanel1.Controls.Add(this.bResetTemplates);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 31);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // bResetTemplates
            // 
            this.bResetTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bResetTemplates.AutoSize = true;
            this.bResetTemplates.Location = new System.Drawing.Point(39, 3);
            this.bResetTemplates.Name = "bResetTemplates";
            this.bResetTemplates.Size = new System.Drawing.Size(97, 23);
            this.bResetTemplates.TabIndex = 51;
            this.bResetTemplates.Text = "Reset Templates";
            this.bResetTemplates.UseVisualStyleBackColor = true;
            this.bResetTemplates.Click += new System.EventHandler(this.bResetTemplates_Click);
            // 
            // IgnoreHidddenFiles
            // 
            this.IgnoreHidddenFiles.AutoSize = true;
            this.IgnoreHidddenFiles.Location = new System.Drawing.Point(16, 24);
            this.IgnoreHidddenFiles.Name = "IgnoreHidddenFiles";
            this.IgnoreHidddenFiles.Size = new System.Drawing.Size(123, 17);
            this.IgnoreHidddenFiles.TabIndex = 53;
            this.IgnoreHidddenFiles.Text = "Ignore Hiddden Files";
            this.IgnoreHidddenFiles.UseVisualStyleBackColor = true;
            // 
            // ReadInputFolderRecursively
            // 
            this.ReadInputFolderRecursively.AutoSize = true;
            this.ReadInputFolderRecursively.Location = new System.Drawing.Point(16, 50);
            this.ReadInputFolderRecursively.Name = "ReadInputFolderRecursively";
            this.ReadInputFolderRecursively.Size = new System.Drawing.Size(169, 17);
            this.ReadInputFolderRecursively.TabIndex = 57;
            this.ReadInputFolderRecursively.Text = "Read Input Folder Recursively";
            this.ReadInputFolderRecursively.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IgnoreHidddenFiles);
            this.groupBox2.Controls.Add(this.ReadInputFolderRecursively);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 83);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 139);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox IgnoreHidddenFiles;
        private System.Windows.Forms.CheckBox ReadInputFolderRecursively;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bResetTemplates;
    }
}