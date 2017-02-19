using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avchd2mp4remuxergui
{
    public partial class FrmMain : Form
    {
        string _pathToFFmpeg = Path.Combine(Application.StartupPath, "ffmpeg.exe");
        string _pathToTsMuxer = Path.Combine(Application.StartupPath, "tsMuxeR.exe");
        string _pathToFMp4Box = Path.Combine(Application.StartupPath, "MP4Box.exe");

        public FrmMain()
        {
            InitializeComponent();
        }

        private void CheckDeps()
        {
            CheckFFmpeg();
            CheckMp4Box();
            CheckTsMuxer();
        }

        private void ValidateFFmpeg()
        {
            ChkDepFFmpeg.ForeColor = Color.Green;
            ChkDepFFmpeg.Checked = true;
            ChkDepFFmpeg.Enabled = false;
            gbxProcess.Enabled = true;
        }
        private void ValidateMp4Box()
        {
            ChkDepMp4Box.ForeColor = Color.Green;
            ChkDepMp4Box.Checked = true;
            ChkDepMp4Box.Enabled = false;
            gbxProcess.Enabled = true;
        }
        private void ValidateTsMuxer()
        {
            ChkDepTsMuxer.ForeColor = Color.Green;
            ChkDepTsMuxer.Checked = true;
            ChkDepTsMuxer.Enabled = false;
            gbxProcess.Enabled = true;
        }

        private void CheckFFmpeg()
        {
            if (File.Exists(_pathToFFmpeg))
            {
                ValidateFFmpeg();
            }
            else
            {
                openFileDialog.Filter = @"FFmpeg binary|ffmpeg.exe|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _pathToFFmpeg = openFileDialog.FileName;
                    ValidateFFmpeg();
                }
                else
                {
                    _pathToFFmpeg = "";
                    ChkDepFFmpeg.Checked = false;
                    ChkDepFFmpeg.ForeColor = Color.Red;
                    ChkDepFFmpeg.Enabled = true;
                    gbxProcess.Enabled = false;
                }
           
            }
        }
        private void CheckMp4Box()
        {
            if (!File.Exists(_pathToFMp4Box))
            {
                openFileDialog.Filter = @"MP4Box binary|MP4Box.exe|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _pathToFMp4Box = openFileDialog.FileName;
                    ValidateMp4Box();
                }
                else
                {
                    _pathToFMp4Box = "";
                    ChkDepMp4Box.Checked = false;
                    ChkDepMp4Box.ForeColor = Color.Red;
                    ChkDepMp4Box.Enabled = true;
                    gbxProcess.Enabled = false;
                }
            }else
            {
                ValidateMp4Box();
            }
        }

        private void CheckTsMuxer()
        {
            if (!File.Exists(_pathToTsMuxer))
            {
                openFileDialog.Filter = @"tsMuxeR binary|tsMuxeR.exe|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _pathToTsMuxer = openFileDialog.FileName;
                    ValidateTsMuxer();
                }
                else
                {
                    _pathToTsMuxer = "";
                    ChkDepTsMuxer.Checked = false;
                    ChkDepTsMuxer.ForeColor = Color.Red;
                    ChkDepTsMuxer.Enabled = true;
                    gbxProcess.Enabled = false;
                }
            }
            else
            {
                ValidateTsMuxer();
            }
        }

        private void ChkDepFFmpeg_CheckedChanged(object sender, EventArgs e)
        {
          CheckFFmpeg();
        }

        private void ChkDepMp4Box_CheckedChanged(object sender, EventArgs e)
        {
            CheckMp4Box();
        }

        private void ChkDepTsMuxer_CheckedChanged(object sender, EventArgs e)
        {
            CheckTsMuxer(); 
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           CheckDeps();
           Activate();
        }
    }
}
