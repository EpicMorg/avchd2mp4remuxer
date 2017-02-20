using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace avchd2mp4remuxergui
{
    public partial class FrmMain : Form
    {
        string _pathToFFmpeg = Path.Combine(Application.StartupPath, "ffmpeg.exe");
        string _pathToFMp4Box = Path.Combine(Application.StartupPath, "MP4Box.exe");
        string _pathToTsMuxer = Path.Combine(Application.StartupPath, "tsMuxeR.exe");
        private string _inputDefaultFormat = "*.MTS";

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
            if (!string.IsNullOrWhiteSpace(txtInputDir.Text) && !string.IsNullOrWhiteSpace(txtOutDir.Text) &&
                !string.IsNullOrWhiteSpace(txtTempDir.Text))
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
            if (!File.Exists(_pathToFFmpeg))
            {
                linkFFmpegCheck.LinkColor = Color.Red;
                ChkDepFFmpeg.Checked = false;
                labelFFmpegCheck.Text = @"не найден!";
            }
            else
            {
                linkFFmpegCheck.LinkColor = Color.ForestGreen;
                ChkDepFFmpeg.Checked = true;
                labelFFmpegCheck.Text = @"найден!";
            }
            if (!File.Exists(_pathToFMp4Box))
            {
                linkMp4BoxCheck.LinkColor = Color.Red;
                ChkDepMp4Box.Checked = false;
                labelMp4BoxCheck.Text = @"не найден!";
            }
            else
            {
                linkMp4BoxCheck.LinkColor = Color.ForestGreen;
                ChkDepMp4Box.Checked = true;
                labelMp4BoxCheck.Text = @"найден!";
            }
            if (!File.Exists(_pathToTsMuxer))
            {
                linktsMuxerCheck.LinkColor = Color.Red;
                ChkDepTsMuxer.Checked = false;
                label3.Text = @"не найден!";
            }
            else
            {
                linktsMuxerCheck.LinkColor = Color.ForestGreen;
                ChkDepTsMuxer.Checked = true;
                label3.Text = @"найден!";
            }
            if (ChkDepTsMuxer.Checked && ChkDepMp4Box.Checked && ChkDepFFmpeg.Checked)
            {
                gbxProcess.Enabled = true;
            }else
            {
                gbxProcess.Enabled = false;
            }
            if (rbMTS.Checked && !rbM2TS.Checked && !rbTS.Checked)
            {
                _inputDefaultFormat = "*.MTS";
            }
            if (!rbMTS.Checked &&rbM2TS.Checked && !rbTS.Checked)
            {
                _inputDefaultFormat = "*.M2TS";
            }
            if (!rbMTS.Checked && !rbM2TS.Checked && rbTS.Checked)
            {
                _inputDefaultFormat = "*.TS";
            }
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

        private void BntAbout_Click(object sender, EventArgs e)
        {
            var frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
            //MessageBox.Show(@"by STAM, 2017" +Environment.NewLine + Environment.NewLine + @"ControlConsole: " +StartProcess.ProductVersion + Environment.NewLine + "WindowsAPICodePack: 1.1.2(1)", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LinkGetFFmpeg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var question = MessageBox.Show(@"Перейти на официальный сайт FFmpeg?", @"Вопрос",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            switch (question)
            {
                case DialogResult.Yes:
                    Process.Start("https://ffmpeg.org/download.html");
                    break;
                case DialogResult.No:
                    if (MessageBox.Show(
                            @"Перейти на сайт готовых сборок FFmpeg?" + Environment.NewLine +
                            @"Рекомендуется выбрать архитектуру, соответсвующую вашей системе, а тип - Shared (Расширенная).",
                            @"Вопрос",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("https://ffmpeg.zeranoe.com/builds/");
                    }
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void LinkGetMp4Box_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(
                    @"Перейти на сайт готовых сборок MP4Box?" + Environment.NewLine +
                    @"Рекомендуется выбрать архитектуру, соответсвующую вашей системе.",
                    @"Вопрос",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("http://www.videohelp.com/software/Mp4box");
            }
        }

        private void LinkGetTsMuxer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(
                    @"Перейти на сайт готовых сборок tsMuxer?",
                    @"Вопрос",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("http://www.videohelp.com/software/tsmuxer");
            }
        }

        private void LinkFFmpegCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Filter = @"FFmpeg binary|ffmpeg.exe|All files|*.*";
            if (!File.Exists(_pathToFFmpeg) && openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                _pathToFFmpeg = openFileDialog.FileName;
            }
            CheckDeps();

        }

        private void LinkMp4BoxCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Filter = @"MP4Box binary|MP4Box.exe|All files|*.*";
            if (!File.Exists(_pathToFMp4Box) && openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                _pathToFMp4Box = openFileDialog.FileName;
            }
            CheckDeps();
        }

        private void LinktsMuxerCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Filter = @"tsMuxeR|tsMuxeR.exe|All files|*.*";
            if (!File.Exists(_pathToTsMuxer) && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _pathToTsMuxer = openFileDialog.FileName;
            }
            CheckDeps();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            CheckDeps();
             var files = Directory.GetFiles(txtInputDir.Text, _inputDefaultFormat, SearchOption.TopDirectoryOnly);
              Parallel.ForEach(files, (file, state, index) =>
              {
                  var outF = Path.Combine(txtTempDir.Text + "\"" + file + ".track_4352.m4v");
                  var ffmpegCmd = " -y -i " + "\"" + file + "\"" + " -c:v copy -an " + "\"" + outF + "\"";
                  MessageBox.Show(_pathToFFmpeg + ffmpegCmd);

              });
            //test only
            /* 
            txtInputDir.Text = txtOutDir.Text = txtTempDir.Text = @"D:\Work\PRIVATE\AVCHD\BDMV\STREAM";
            var inputF = Path.Combine(txtInputDir.Text + "00000.MTS");
            var outF = Path.Combine(txtTempDir.Text + "00000.track_4352.m4v");
           
            //MessageBox.Show(ffmpegCmd);
            StartProcess.StartProcess(_pathToFFmpeg, ffmpegCmd);
            StartProcess.AutoScroll = true;
            SendMessage(StartProcess.Handle, WmVscroll, SbBottom, 0x0);
            */

        }

    }
}
