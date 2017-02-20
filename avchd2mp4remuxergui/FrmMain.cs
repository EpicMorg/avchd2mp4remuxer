using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleControl;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

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
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr window, int message, int wparam, int lparam);

        private const int SbBottom = 0x7;
        private const int WmVscroll = 0x115;
  
    private void CheckDeps()
        {
            CheckFFmpeg(true);
            CheckMp4Box(true);
            CheckTsMuxer(true);
            if (!string.IsNullOrWhiteSpace(txtInputDir.Text) && !string.IsNullOrWhiteSpace(txtOutDir.Text) &&
                !string.IsNullOrWhiteSpace(txtTempDir.Text))
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
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

        private void CheckFFmpeg(bool bCheckFFmpeg)
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
        private void CheckMp4Box(bool bCheckMp4Box)
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

        public void CheckTsMuxer(bool bCheckTsMuxer)
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

        private void BtnInputDir_Click(object sender, EventArgs e) 
        {
            var dlg = new CommonOpenFileDialog
            {
                Title = "Выбор папки с исходниками",
                IsFolderPicker = true,
                InitialDirectory  = Application.StartupPath,
                DefaultDirectory = Application.StartupPath,
                AddToMostRecentlyUsedList = false,
                AllowNonFileSystemItems = false,
                EnsureFileExists = true,
                EnsurePathExists = true,
                EnsureReadOnly = false,
                EnsureValidNames = true,
                Multiselect = false,
                ShowPlacesList = true, 
            };
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtInputDir.Text = dlg.FileName;
            }
            CheckDeps();
        }

        private void BtnTempDir_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                Title = "Выбор папки кэша",
                IsFolderPicker = true,
                InitialDirectory = Application.StartupPath,
                DefaultDirectory = Application.StartupPath,
                AddToMostRecentlyUsedList = false,
                AllowNonFileSystemItems = false,
                EnsureFileExists = true,
                EnsurePathExists = true,
                EnsureReadOnly = false,
                EnsureValidNames = true,
                Multiselect = false,
                ShowPlacesList = true,
            };
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtTempDir.Text = dlg.FileName;
            }
           
            CheckDeps();
        }

        private void BtnOutDir_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                Title = "Выбор папки с готовыми файлами",
                IsFolderPicker = true,
                InitialDirectory = Application.StartupPath,
                DefaultDirectory = Application.StartupPath,
                AddToMostRecentlyUsedList = false,
                AllowNonFileSystemItems = false,
                EnsureFileExists = true,
                EnsurePathExists = true,
                EnsureReadOnly = false,
                EnsureValidNames = true,
                Multiselect = false,
                ShowPlacesList = true,
            };
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtOutDir.Text = dlg.FileName;
            }
            CheckDeps();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
                //test only
                /*
                txtInputDir.Text = txtOutDir.Text = txtTempDir.Text = @"D:\Work\PRIVATE\AVCHD\BDMV\STREAM";
                var inputF = Path.Combine(txtInputDir.Text + "00000.MTS");
                var outF = Path.Combine(txtTempDir.Text + "00000.track_4352.m4v");
                var ffmpegCmd = "-y -i " + "\"" + inputF + "\"" + " -c:v copy -an " + "\"" + outF + "\"";
                //MessageBox.Show(ffmpegCmd);
                StartProcess.StartProcess(_pathToFFmpeg, ffmpegCmd);
                StartProcess.AutoScroll = true;
                SendMessage(StartProcess.Handle, WmVscroll, SbBottom, 0x0);
                */
       
        }

        private void BntAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by STAM, 2017" +Environment.NewLine + Environment.NewLine + "ControlConsole: " +StartProcess.ProductVersion + Environment.NewLine + "WindowsAPICodePack: 1.1.2(1)", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
