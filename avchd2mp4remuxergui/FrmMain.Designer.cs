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
            this.gbxDeps = new System.Windows.Forms.GroupBox();
            this.chkDepTsMuxer = new System.Windows.Forms.CheckBox();
            this.chkDepMp4Box = new System.Windows.Forms.CheckBox();
            this.chkDepFFmpeg = new System.Windows.Forms.CheckBox();
            this.gbxDeps.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDeps
            // 
            this.gbxDeps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDeps.Controls.Add(this.chkDepTsMuxer);
            this.gbxDeps.Controls.Add(this.chkDepMp4Box);
            this.gbxDeps.Controls.Add(this.chkDepFFmpeg);
            this.gbxDeps.Location = new System.Drawing.Point(12, 12);
            this.gbxDeps.Name = "gbxDeps";
            this.gbxDeps.Size = new System.Drawing.Size(390, 44);
            this.gbxDeps.TabIndex = 0;
            this.gbxDeps.TabStop = false;
            this.gbxDeps.Text = "Зависимости";
            // 
            // chkDepTsMuxer
            // 
            this.chkDepTsMuxer.AutoSize = true;
            this.chkDepTsMuxer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkDepTsMuxer.Location = new System.Drawing.Point(202, 19);
            this.chkDepTsMuxer.Name = "chkDepTsMuxer";
            this.chkDepTsMuxer.Size = new System.Drawing.Size(99, 17);
            this.chkDepTsMuxer.TabIndex = 0;
            this.chkDepTsMuxer.Text = "tsMuxeR.exe";
            this.chkDepTsMuxer.UseVisualStyleBackColor = true;
            // 
            // chkDepMp4Box
            // 
            this.chkDepMp4Box.AutoSize = true;
            this.chkDepMp4Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkDepMp4Box.Location = new System.Drawing.Point(100, 19);
            this.chkDepMp4Box.Name = "chkDepMp4Box";
            this.chkDepMp4Box.Size = new System.Drawing.Size(96, 17);
            this.chkDepMp4Box.TabIndex = 0;
            this.chkDepMp4Box.Text = "MP4Box.exe";
            this.chkDepMp4Box.UseVisualStyleBackColor = true;
            // 
            // chkDepFFmpeg
            // 
            this.chkDepFFmpeg.AutoSize = true;
            this.chkDepFFmpeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkDepFFmpeg.Location = new System.Drawing.Point(6, 19);
            this.chkDepFFmpeg.Name = "chkDepFFmpeg";
            this.chkDepFFmpeg.Size = new System.Drawing.Size(88, 17);
            this.chkDepFFmpeg.TabIndex = 0;
            this.chkDepFFmpeg.Text = "ffmpeg.exe";
            this.chkDepFFmpeg.UseVisualStyleBackColor = true;
            this.chkDepFFmpeg.CheckedChanged += new System.EventHandler(this.chkDepFFmpeg_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 232);
            this.Controls.Add(this.gbxDeps);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvcHD2Mp4 remuxer GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxDeps.ResumeLayout(false);
            this.gbxDeps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDeps;
        private System.Windows.Forms.CheckBox chkDepTsMuxer;
        private System.Windows.Forms.CheckBox chkDepMp4Box;
        private System.Windows.Forms.CheckBox chkDepFFmpeg;
    }
}

