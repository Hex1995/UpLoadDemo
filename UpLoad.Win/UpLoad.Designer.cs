namespace UpLoad.Win
{
    partial class UpLoad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.RicMsg = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSelectFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSelectFile.Location = new System.Drawing.Point(907, 42);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 0;
            this.BtnSelectFile.Text = "选择文件";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择文件";
            // 
            // TxtPath
            // 
            this.TxtPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPath.Location = new System.Drawing.Point(225, 44);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(575, 21);
            this.TxtPath.TabIndex = 2;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpload.Location = new System.Drawing.Point(1007, 42);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(75, 23);
            this.BtnUpload.TabIndex = 3;
            this.BtnUpload.Text = "上传文件";
            this.BtnUpload.UseVisualStyleBackColor = true;
            // 
            // RicMsg
            // 
            this.RicMsg.BackColor = System.Drawing.SystemColors.MenuText;
            this.RicMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RicMsg.ForeColor = System.Drawing.SystemColors.Info;
            this.RicMsg.Location = new System.Drawing.Point(0, 0);
            this.RicMsg.Name = "RicMsg";
            this.RicMsg.Size = new System.Drawing.Size(1116, 571);
            this.RicMsg.TabIndex = 4;
            this.RicMsg.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSelectFolder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSelectFile);
            this.panel1.Controls.Add(this.BtnUpload);
            this.panel1.Controls.Add(this.TxtPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 104);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RicMsg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 571);
            this.panel2.TabIndex = 6;
            // 
            // BtnSelectFolder
            // 
            this.BtnSelectFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSelectFolder.Location = new System.Drawing.Point(816, 42);
            this.BtnSelectFolder.Name = "BtnSelectFolder";
            this.BtnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFolder.TabIndex = 4;
            this.BtnSelectFolder.Text = "选择文件夹";
            this.BtnSelectFolder.UseVisualStyleBackColor = true;
            this.BtnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // UpLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpLoad";
            this.Text = "上传文件";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.RichTextBox RicMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSelectFolder;
    }
}

