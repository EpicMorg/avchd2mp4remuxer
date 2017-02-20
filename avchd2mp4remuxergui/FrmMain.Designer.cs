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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gbxDeps = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMp4BoxCheck = new System.Windows.Forms.Label();
            this.labelFFmpegCheck = new System.Windows.Forms.Label();
            this.linktsMuxerCheck = new System.Windows.Forms.LinkLabel();
            this.linkMp4BoxCheck = new System.Windows.Forms.LinkLabel();
            this.linkFFmpegCheck = new System.Windows.Forms.LinkLabel();
            this.linkGetTsMuxer = new System.Windows.Forms.LinkLabel();
            this.linkGetMp4Box = new System.Windows.Forms.LinkLabel();
            this.linkGetFFmpeg = new System.Windows.Forms.LinkLabel();
            this.ChkDepTsMuxer = new System.Windows.Forms.CheckBox();
            this.ChkDepMp4Box = new System.Windows.Forms.CheckBox();
            this.ChkDepFFmpeg = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gbxProcess = new System.Windows.Forms.GroupBox();
            this.lblOutPutLog = new System.Windows.Forms.Label();
            this.StartProcess = new ConsoleControl.ConsoleControl();
            this.btnOutDir = new System.Windows.Forms.Button();
            this.btnTempDir = new System.Windows.Forms.Button();
            this.btnInputDir = new System.Windows.Forms.Button();
            this.lblOutDir = new System.Windows.Forms.Label();
            this.txtOutDir = new System.Windows.Forms.TextBox();
            this.lblTempDir = new System.Windows.Forms.Label();
            this.txtTempDir = new System.Windows.Forms.TextBox();
            this.lblInputDir = new System.Windows.Forms.Label();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.rbMTS = new System.Windows.Forms.RadioButton();
            this.rbM2TS = new System.Windows.Forms.RadioButton();
            this.rbTS = new System.Windows.Forms.RadioButton();
            this.gbxDeps.SuspendLayout();
            this.gbxProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDeps
            // 
            this.gbxDeps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDeps.Controls.Add(this.label3);
            this.gbxDeps.Controls.Add(this.labelMp4BoxCheck);
            this.gbxDeps.Controls.Add(this.labelFFmpegCheck);
            this.gbxDeps.Controls.Add(this.linktsMuxerCheck);
            this.gbxDeps.Controls.Add(this.linkMp4BoxCheck);
            this.gbxDeps.Controls.Add(this.linkFFmpegCheck);
            this.gbxDeps.Controls.Add(this.linkGetTsMuxer);
            this.gbxDeps.Controls.Add(this.linkGetMp4Box);
            this.gbxDeps.Controls.Add(this.linkGetFFmpeg);
            this.gbxDeps.Controls.Add(this.ChkDepTsMuxer);
            this.gbxDeps.Controls.Add(this.ChkDepMp4Box);
            this.gbxDeps.Controls.Add(this.ChkDepFFmpeg);
            this.gbxDeps.Location = new System.Drawing.Point(12, 12);
            this.gbxDeps.Name = "gbxDeps";
            this.gbxDeps.Size = new System.Drawing.Size(281, 90);
            this.gbxDeps.TabIndex = 0;
            this.gbxDeps.TabStop = false;
            this.gbxDeps.Text = "Зависимости:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "не найден!";
            // 
            // labelMp4BoxCheck
            // 
            this.labelMp4BoxCheck.AutoSize = true;
            this.labelMp4BoxCheck.Location = new System.Drawing.Point(87, 42);
            this.labelMp4BoxCheck.Name = "labelMp4BoxCheck";
            this.labelMp4BoxCheck.Size = new System.Drawing.Size(61, 13);
            this.labelMp4BoxCheck.TabIndex = 8;
            this.labelMp4BoxCheck.Text = "не найден!";
            // 
            // labelFFmpegCheck
            // 
            this.labelFFmpegCheck.AutoSize = true;
            this.labelFFmpegCheck.Location = new System.Drawing.Point(87, 19);
            this.labelFFmpegCheck.Name = "labelFFmpegCheck";
            this.labelFFmpegCheck.Size = new System.Drawing.Size(61, 13);
            this.labelFFmpegCheck.TabIndex = 8;
            this.labelFFmpegCheck.Text = "не найден!";
            // 
            // linktsMuxerCheck
            // 
            this.linktsMuxerCheck.AutoSize = true;
            this.linktsMuxerCheck.LinkColor = System.Drawing.Color.Gray;
            this.linktsMuxerCheck.Location = new System.Drawing.Point(27, 65);
            this.linktsMuxerCheck.Name = "linktsMuxerCheck";
            this.linktsMuxerCheck.Size = new System.Drawing.Size(44, 13);
            this.linktsMuxerCheck.TabIndex = 7;
            this.linktsMuxerCheck.TabStop = true;
            this.linktsMuxerCheck.Text = "tsMuxer";
            this.linktsMuxerCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinktsMuxerCheck_LinkClicked);
            // 
            // linkMp4BoxCheck
            // 
            this.linkMp4BoxCheck.AutoSize = true;
            this.linkMp4BoxCheck.LinkColor = System.Drawing.Color.Gray;
            this.linkMp4BoxCheck.Location = new System.Drawing.Point(27, 42);
            this.linkMp4BoxCheck.Name = "linkMp4BoxCheck";
            this.linkMp4BoxCheck.Size = new System.Drawing.Size(50, 13);
            this.linkMp4BoxCheck.TabIndex = 7;
            this.linkMp4BoxCheck.TabStop = true;
            this.linkMp4BoxCheck.Text = "MP4 Box";
            this.linkMp4BoxCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMp4BoxCheck_LinkClicked);
            // 
            // linkFFmpegCheck
            // 
            this.linkFFmpegCheck.AutoSize = true;
            this.linkFFmpegCheck.LinkColor = System.Drawing.Color.Gray;
            this.linkFFmpegCheck.Location = new System.Drawing.Point(27, 19);
            this.linkFFmpegCheck.Name = "linkFFmpegCheck";
            this.linkFFmpegCheck.Size = new System.Drawing.Size(45, 13);
            this.linkFFmpegCheck.TabIndex = 7;
            this.linkFFmpegCheck.TabStop = true;
            this.linkFFmpegCheck.Text = "FFmpeg";
            this.linkFFmpegCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFFmpegCheck_LinkClicked);
            // 
            // linkGetTsMuxer
            // 
            this.linkGetTsMuxer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGetTsMuxer.AutoSize = true;
            this.linkGetTsMuxer.Location = new System.Drawing.Point(187, 65);
            this.linkGetTsMuxer.Name = "linkGetTsMuxer";
            this.linkGetTsMuxer.Size = new System.Drawing.Size(88, 13);
            this.linkGetTsMuxer.TabIndex = 3;
            this.linkGetTsMuxer.TabStop = true;
            this.linkGetTsMuxer.Text = "Скачать tsMuxer";
            this.linkGetTsMuxer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGetTsMuxer_LinkClicked);
            // 
            // linkGetMp4Box
            // 
            this.linkGetMp4Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGetMp4Box.AutoSize = true;
            this.linkGetMp4Box.Location = new System.Drawing.Point(187, 42);
            this.linkGetMp4Box.Name = "linkGetMp4Box";
            this.linkGetMp4Box.Size = new System.Drawing.Size(90, 13);
            this.linkGetMp4Box.TabIndex = 2;
            this.linkGetMp4Box.TabStop = true;
            this.linkGetMp4Box.Text = "Скачать MP4box";
            this.linkGetMp4Box.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGetMp4Box_LinkClicked);
            // 
            // linkGetFFmpeg
            // 
            this.linkGetFFmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGetFFmpeg.AutoSize = true;
            this.linkGetFFmpeg.Location = new System.Drawing.Point(186, 19);
            this.linkGetFFmpeg.Name = "linkGetFFmpeg";
            this.linkGetFFmpeg.Size = new System.Drawing.Size(89, 13);
            this.linkGetFFmpeg.TabIndex = 1;
            this.linkGetFFmpeg.TabStop = true;
            this.linkGetFFmpeg.Text = "Скачать FFmpeg";
            this.linkGetFFmpeg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGetFFmpeg_LinkClicked);
            // 
            // ChkDepTsMuxer
            // 
            this.ChkDepTsMuxer.AutoSize = true;
            this.ChkDepTsMuxer.Enabled = false;
            this.ChkDepTsMuxer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkDepTsMuxer.ForeColor = System.Drawing.Color.Red;
            this.ChkDepTsMuxer.Location = new System.Drawing.Point(6, 65);
            this.ChkDepTsMuxer.Name = "ChkDepTsMuxer";
            this.ChkDepTsMuxer.Size = new System.Drawing.Size(15, 14);
            this.ChkDepTsMuxer.TabIndex = 0;
            this.toolTip.SetToolTip(this.ChkDepTsMuxer, "tsMuxeR не найден!");
            this.ChkDepTsMuxer.UseVisualStyleBackColor = true;
            // 
            // ChkDepMp4Box
            // 
            this.ChkDepMp4Box.AutoSize = true;
            this.ChkDepMp4Box.Enabled = false;
            this.ChkDepMp4Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkDepMp4Box.ForeColor = System.Drawing.Color.Red;
            this.ChkDepMp4Box.Location = new System.Drawing.Point(6, 42);
            this.ChkDepMp4Box.Name = "ChkDepMp4Box";
            this.ChkDepMp4Box.Size = new System.Drawing.Size(15, 14);
            this.ChkDepMp4Box.TabIndex = 0;
            this.ChkDepMp4Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.ChkDepMp4Box, "MP4Box не найден!");
            this.ChkDepMp4Box.UseVisualStyleBackColor = true;
            // 
            // ChkDepFFmpeg
            // 
            this.ChkDepFFmpeg.AutoSize = true;
            this.ChkDepFFmpeg.Enabled = false;
            this.ChkDepFFmpeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkDepFFmpeg.ForeColor = System.Drawing.Color.Red;
            this.ChkDepFFmpeg.Location = new System.Drawing.Point(6, 19);
            this.ChkDepFFmpeg.Name = "ChkDepFFmpeg";
            this.ChkDepFFmpeg.Size = new System.Drawing.Size(15, 14);
            this.ChkDepFFmpeg.TabIndex = 0;
            this.toolTip.SetToolTip(this.ChkDepFFmpeg, "ffmpeg не найден!");
            this.ChkDepFFmpeg.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(299, 49);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(153, 23);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BntAbout_Click);
            // 
            // gbxProcess
            // 
            this.gbxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProcess.Controls.Add(this.lblOutPutLog);
            this.gbxProcess.Controls.Add(this.StartProcess);
            this.gbxProcess.Controls.Add(this.btnOutDir);
            this.gbxProcess.Controls.Add(this.btnTempDir);
            this.gbxProcess.Controls.Add(this.btnInputDir);
            this.gbxProcess.Controls.Add(this.lblOutDir);
            this.gbxProcess.Controls.Add(this.txtOutDir);
            this.gbxProcess.Controls.Add(this.lblTempDir);
            this.gbxProcess.Controls.Add(this.txtTempDir);
            this.gbxProcess.Controls.Add(this.lblInputDir);
            this.gbxProcess.Controls.Add(this.txtInputDir);
            this.gbxProcess.Enabled = false;
            this.gbxProcess.Location = new System.Drawing.Point(12, 108);
            this.gbxProcess.Name = "gbxProcess";
            this.gbxProcess.Size = new System.Drawing.Size(440, 306);
            this.gbxProcess.TabIndex = 1;
            this.gbxProcess.TabStop = false;
            this.gbxProcess.Text = "Папки:";
            // 
            // lblOutPutLog
            // 
            this.lblOutPutLog.AutoSize = true;
            this.lblOutPutLog.Location = new System.Drawing.Point(6, 133);
            this.lblOutPutLog.Name = "lblOutPutLog";
            this.lblOutPutLog.Size = new System.Drawing.Size(88, 13);
            this.lblOutPutLog.TabIndex = 6;
            this.lblOutPutLog.Text = "Вывод консоли:";
            // 
            // StartProcess
            // 
            this.StartProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartProcess.IsInputEnabled = true;
            this.StartProcess.Location = new System.Drawing.Point(6, 149);
            this.StartProcess.Name = "StartProcess";
            this.StartProcess.SendKeyboardCommandsToProcess = false;
            this.StartProcess.ShowDiagnostics = false;
            this.StartProcess.Size = new System.Drawing.Size(428, 151);
            this.StartProcess.TabIndex = 5;
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
            this.btnOutDir.Click += new System.EventHandler(this.BtnOutDir_Click);
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
            this.btnTempDir.Click += new System.EventHandler(this.BtnTempDir_Click);
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
            this.btnInputDir.Click += new System.EventHandler(this.BtnInputDir_Click);
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
            // lblTempDir
            // 
            this.lblTempDir.AutoSize = true;
            this.lblTempDir.Location = new System.Drawing.Point(6, 55);
            this.lblTempDir.Name = "lblTempDir";
            this.lblTempDir.Size = new System.Drawing.Size(85, 13);
            this.lblTempDir.TabIndex = 1;
            this.lblTempDir.Text = "Папка с кэшэм";
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
            // lblInputDir
            // 
            this.lblInputDir.AutoSize = true;
            this.lblInputDir.Location = new System.Drawing.Point(6, 16);
            this.lblInputDir.Name = "lblInputDir";
            this.lblInputDir.Size = new System.Drawing.Size(94, 13);
            this.lblInputDir.TabIndex = 1;
            this.lblInputDir.Text = "Входящая папка:";
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
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(299, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
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
            // rbMTS
            // 
            this.rbMTS.AutoSize = true;
            this.rbMTS.Checked = true;
            this.rbMTS.Location = new System.Drawing.Point(299, 26);
            this.rbMTS.Name = "rbMTS";
            this.rbMTS.Size = new System.Drawing.Size(48, 17);
            this.rbMTS.TabIndex = 7;
            this.rbMTS.TabStop = true;
            this.rbMTS.Text = "MTS";
            this.rbMTS.UseVisualStyleBackColor = true;
            // 
            // rbM2TS
            // 
            this.rbM2TS.AutoSize = true;
            this.rbM2TS.Enabled = false;
            this.rbM2TS.Location = new System.Drawing.Point(353, 26);
            this.rbM2TS.Name = "rbM2TS";
            this.rbM2TS.Size = new System.Drawing.Size(54, 17);
            this.rbM2TS.TabIndex = 8;
            this.rbM2TS.Text = "M2TS";
            this.rbM2TS.UseVisualStyleBackColor = true;
            // 
            // rbTS
            // 
            this.rbTS.AutoSize = true;
            this.rbTS.Enabled = false;
            this.rbTS.Location = new System.Drawing.Point(413, 26);
            this.rbTS.Name = "rbTS";
            this.rbTS.Size = new System.Drawing.Size(39, 17);
            this.rbTS.TabIndex = 8;
            this.rbTS.Text = "TS";
            this.rbTS.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 426);
            this.Controls.Add(this.rbTS);
            this.Controls.Add(this.rbM2TS);
            this.Controls.Add(this.rbMTS);
            this.Controls.Add(this.gbxProcess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbxDeps);
            this.Controls.Add(this.btnAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 390);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVCHD 2 Mp4 Remuxer GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxDeps.ResumeLayout(false);
            this.gbxDeps.PerformLayout();
            this.gbxProcess.ResumeLayout(false);
            this.gbxProcess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnStart;
        private ConsoleControl.ConsoleControl StartProcess;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.LinkLabel linkGetTsMuxer;
        private System.Windows.Forms.LinkLabel linkGetMp4Box;
        private System.Windows.Forms.LinkLabel linkGetFFmpeg;
        private System.Windows.Forms.LinkLabel linktsMuxerCheck;
        private System.Windows.Forms.LinkLabel linkMp4BoxCheck;
        private System.Windows.Forms.LinkLabel linkFFmpegCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMp4BoxCheck;
        private System.Windows.Forms.Label labelFFmpegCheck;
        private System.Windows.Forms.Label lblOutPutLog;
        private System.Windows.Forms.RadioButton rbMTS;
        private System.Windows.Forms.RadioButton rbM2TS;
        private System.Windows.Forms.RadioButton rbTS;
    }
}

