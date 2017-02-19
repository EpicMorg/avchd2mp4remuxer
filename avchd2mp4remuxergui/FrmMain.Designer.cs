namespace avchd2mp4remuxergui
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxDeps = new System.Windows.Forms.GroupBox();
            this.ChkDepTsMuxer = new System.Windows.Forms.CheckBox();
            this.ChkDepMp4Box = new System.Windows.Forms.CheckBox();
            this.ChkDepFFmpeg = new System.Windows.Forms.CheckBox();
            this.gbxProcess = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.lblInputDir = new System.Windows.Forms.Label();
            this.txtTempDir = new System.Windows.Forms.TextBox();
            this.lblTempDir = new System.Windows.Forms.Label();
            this.txtOutDir = new System.Windows.Forms.TextBox();
            this.lblOutDir = new System.Windows.Forms.Label();
            this.btnInputDir = new System.Windows.Forms.Button();
            this.btnTempDir = new System.Windows.Forms.Button();
            this.btnOutDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxDeps.SuspendLayout();
            this.gbxProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDeps
            // 
            this.gbxDeps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDeps.Controls.Add(this.ChkDepTsMuxer);
            this.gbxDeps.Controls.Add(this.ChkDepMp4Box);
            this.gbxDeps.Controls.Add(this.ChkDepFFmpeg);
            this.gbxDeps.Location = new System.Drawing.Point(12, 12);
            this.gbxDeps.Name = "gbxDeps";
            this.gbxDeps.Size = new System.Drawing.Size(440, 44);
            this.gbxDeps.TabIndex = 0;
            this.gbxDeps.TabStop = false;
            this.gbxDeps.Text = "Зависимости";
            // 
            // ChkDepTsMuxer
            // 
            this.ChkDepTsMuxer.AutoSize = true;
            this.ChkDepTsMuxer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkDepTsMuxer.ForeColor = System.Drawing.Color.Red;
            this.ChkDepTsMuxer.Location = new System.Drawing.Point(202, 19);
            this.ChkDepTsMuxer.Name = "ChkDepTsMuxer";
            this.ChkDepTsMuxer.Size = new System.Drawing.Size(99, 17);
            this.ChkDepTsMuxer.TabIndex = 0;
            this.ChkDepTsMuxer.Text = "tsMuxeR.exe";
            this.toolTip.SetToolTip(this.ChkDepTsMuxer, "tsMuxeR не найден!");
            this.ChkDepTsMuxer.UseVisualStyleBackColor = true;
            this.ChkDepTsMuxer.CheckedChanged += new System.EventHandler(this.ChkDepTsMuxer_CheckedChanged);
            // 
            // ChkDepMp4Box
            // 
            this.ChkDepMp4Box.AutoSize = true;
            this.ChkDepMp4Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkDepMp4Box.ForeColor = System.Drawing.Color.Red;
            this.ChkDepMp4Box.Location = new System.Drawing.Point(100, 19);
            this.ChkDepMp4Box.Name = "ChkDepMp4Box";
            this.ChkDepMp4Box.Size = new System.Drawing.Size(96, 17);
            this.ChkDepMp4Box.TabIndex = 0;
            this.ChkDepMp4Box.Text = "MP4Box.exe";
            this.ChkDepMp4Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.ChkDepMp4Box, "MP4Box не найден!");
            this.ChkDepMp4Box.UseVisualStyleBackColor = true;
            this.ChkDepMp4Box.CheckedChanged += new System.EventHandler(this.ChkDepMp4Box_CheckedChanged);
            // 
            // ChkDepFFmpeg
            // 
            this.ChkDepFFmpeg.AutoSize = true;
            this.ChkDepFFmpeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkDepFFmpeg.ForeColor = System.Drawing.Color.Red;
            this.ChkDepFFmpeg.Location = new System.Drawing.Point(6, 19);
            this.ChkDepFFmpeg.Name = "ChkDepFFmpeg";
            this.ChkDepFFmpeg.Size = new System.Drawing.Size(88, 17);
            this.ChkDepFFmpeg.TabIndex = 0;
            this.ChkDepFFmpeg.Text = "ffmpeg.exe";
            this.toolTip.SetToolTip(this.ChkDepFFmpeg, "ffmpeg не найден!");
            this.ChkDepFFmpeg.UseVisualStyleBackColor = true;
            this.ChkDepFFmpeg.CheckedChanged += new System.EventHandler(this.ChkDepFFmpeg_CheckedChanged);
            // 
            // gbxProcess
            // 
            this.gbxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProcess.Controls.Add(this.btnOutDir);
            this.gbxProcess.Controls.Add(this.btnTempDir);
            this.gbxProcess.Controls.Add(this.btnInputDir);
            this.gbxProcess.Controls.Add(this.lblOutDir);
            this.gbxProcess.Controls.Add(this.txtOutDir);
            this.gbxProcess.Controls.Add(this.lblTempDir);
            this.gbxProcess.Controls.Add(this.txtTempDir);
            this.gbxProcess.Controls.Add(this.lblInputDir);
            this.gbxProcess.Controls.Add(this.txtInputDir);
            this.gbxProcess.Location = new System.Drawing.Point(12, 62);
            this.gbxProcess.Name = "gbxProcess";
            this.gbxProcess.Size = new System.Drawing.Size(440, 277);
            this.gbxProcess.TabIndex = 1;
            this.gbxProcess.TabStop = false;
            this.gbxProcess.Text = "Процесс";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "FFmpeg binary|ffmpeg.exe|MP4Box binary|MP4Box.exe|tsMuxeR|tsMuxeR.exe|All files|*" +
    ".*";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip.ToolTipTitle = "Внивание!";
            // 
            // txtInputDir
            // 
            this.txtInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputDir.Location = new System.Drawing.Point(6, 32);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.ReadOnly = true;
            this.txtInputDir.Size = new System.Drawing.Size(371, 20);
            this.txtInputDir.TabIndex = 0;
            // 
            // lblInputDir
            // 
            this.lblInputDir.AutoSize = true;
            this.lblInputDir.Location = new System.Drawing.Point(6, 16);
            this.lblInputDir.Name = "lblInputDir";
            this.lblInputDir.Size = new System.Drawing.Size(94, 13);
            this.lblInputDir.TabIndex = 1;
            this.lblInputDir.Text = "Входящая папка:";
            // 
            // txtTempDir
            // 
            this.txtTempDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTempDir.Location = new System.Drawing.Point(6, 71);
            this.txtTempDir.Name = "txtTempDir";
            this.txtTempDir.ReadOnly = true;
            this.txtTempDir.Size = new System.Drawing.Size(371, 20);
            this.txtTempDir.TabIndex = 0;
            // 
            // lblTempDir
            // 
            this.lblTempDir.AutoSize = true;
            this.lblTempDir.Location = new System.Drawing.Point(6, 55);
            this.lblTempDir.Name = "lblTempDir";
            this.lblTempDir.Size = new System.Drawing.Size(100, 13);
            this.lblTempDir.TabIndex = 1;
            this.lblTempDir.Text = "Временная папка:";
            // 
            // txtOutDir
            // 
            this.txtOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutDir.Location = new System.Drawing.Point(6, 110);
            this.txtOutDir.Name = "txtOutDir";
            this.txtOutDir.ReadOnly = true;
            this.txtOutDir.Size = new System.Drawing.Size(371, 20);
            this.txtOutDir.TabIndex = 0;
            // 
            // lblOutDir
            // 
            this.lblOutDir.AutoSize = true;
            this.lblOutDir.Location = new System.Drawing.Point(6, 94);
            this.lblOutDir.Name = "lblOutDir";
            this.lblOutDir.Size = new System.Drawing.Size(101, 13);
            this.lblOutDir.TabIndex = 1;
            this.lblOutDir.Text = "Исходящая папка:";
            // 
            // btnInputDir
            // 
            this.btnInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputDir.Location = new System.Drawing.Point(383, 30);
            this.btnInputDir.Name = "btnInputDir";
            this.btnInputDir.Size = new System.Drawing.Size(51, 23);
            this.btnInputDir.TabIndex = 2;
            this.btnInputDir.Text = "...";
            this.btnInputDir.UseVisualStyleBackColor = true;
            // 
            // btnTempDir
            // 
            this.btnTempDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTempDir.Location = new System.Drawing.Point(383, 69);
            this.btnTempDir.Name = "btnTempDir";
            this.btnTempDir.Size = new System.Drawing.Size(51, 23);
            this.btnTempDir.TabIndex = 2;
            this.btnTempDir.Text = "...";
            this.btnTempDir.UseVisualStyleBackColor = true;
            // 
            // btnOutDir
            // 
            this.btnOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutDir.Location = new System.Drawing.Point(383, 108);
            this.btnOutDir.Name = "btnOutDir";
            this.btnOutDir.Size = new System.Drawing.Size(51, 23);
            this.btnOutDir.TabIndex = 2;
            this.btnOutDir.Text = "...";
            this.btnOutDir.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 351);
            this.Controls.Add(this.gbxProcess);
            this.Controls.Add(this.gbxDeps);
            this.MinimumSize = new System.Drawing.Size(480, 390);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvcHD2Mp4 remuxer GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxDeps.ResumeLayout(false);
            this.gbxDeps.PerformLayout();
            this.gbxProcess.ResumeLayout(false);
            this.gbxProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDeps;
        private System.Windows.Forms.CheckBox ChkDepTsMuxer;
        private System.Windows.Forms.CheckBox ChkDepMp4Box;
        private System.Windows.Forms.CheckBox ChkDepFFmpeg;
        private System.Windows.Forms.GroupBox gbxProcess;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnOutDir;
        private System.Windows.Forms.Button btnTempDir;
        private System.Windows.Forms.Button btnInputDir;
        private System.Windows.Forms.Label lblOutDir;
        private System.Windows.Forms.TextBox txtOutDir;
        private System.Windows.Forms.Label lblTempDir;
        private System.Windows.Forms.TextBox txtTempDir;
        private System.Windows.Forms.Label lblInputDir;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

