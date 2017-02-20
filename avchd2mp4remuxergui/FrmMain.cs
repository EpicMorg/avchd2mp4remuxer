using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleControlAPI;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace avchd2mp4remuxergui
{
    public partial class FrmMain : Form
    {
        private string _pathToFFmpeg = Path.Combine(Application.StartupPath, "ffmpeg.exe");
        private string _pathToFMp4Box = Path.Combine(Application.StartupPath, "MP4Box.exe");
        private string _pathToTsMuxer = Path.Combine(Application.StartupPath, "tsMuxeR.exe");
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
            btnStart.Enabled = (!string.IsNullOrWhiteSpace(txtInputDir.Text) && !string.IsNullOrWhiteSpace(txtOutDir.Text) &&
                !string.IsNullOrWhiteSpace(txtTempDir.Text));

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
            gbxProcess.Enabled = (ChkDepTsMuxer.Checked && ChkDepMp4Box.Checked && ChkDepFFmpeg.Checked);
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
            // Шаг 1. Из сорцовой папки делаем выборку по файлам по заданной маске (радиобатоном, пока только MTS) 
            var files = Directory.GetFiles(txtInputDir.Text, _inputDefaultFormat, SearchOption.TopDirectoryOnly);
           // вывод первого списка файлов
            foreach (var t in files)
            {
                // Но должно запускаться по-очереди, а не одновременно. Надо починить..
                var m4VFile = Path.GetFileNameWithoutExtension(t);
                var outF = Path.Combine(txtTempDir.Text + @"\" + m4VFile + ".track_4352.m4v");
                var ffmpegCmd = " -y -i " + "\"" + t + "\"" + " -c:v copy -an " + "\"" + outF + "\"";
                //Для отладки...
                MessageBox.Show(_pathToFFmpeg + ffmpegCmd);
                Process.Start(_pathToFFmpeg + ffmpegCmd);
            }
            // Parallel.ForEach(
            //  files, new ParallelOptions { MaxDegreeOfParallelism = 1 },
            //   (file, state, index) =>
            //    {
            // Шаг 2. Дальше запускается что-то вроде \\\\ffmpeg -i "ПОЛНЫЙПУТЬКМТС.MTS" -c:v copy -an  "ПОЛНЫЙПУТЬДЛЯВИДЕО.track_4352.m4v"\\\\


            // Пока вывод во встроенную консоль отключен, ибо заускаетя параллельно.. Использовать Process.Start();
            //StartProcess.StartProcess(_pathToFFmpeg, ffmpegCmd);
            //StartProcess.AutoScroll = true;
            //SendMessage(StartProcess.Handle, WmVscroll, SbBottom, 0x0);

            // Шаг 3. создаем метафайл на  mts-файл который будем демуксовать.
            // Писать в выбранную темповую папку файл default.meta с примерным содержимым:
            // \\\\MUXOPT--no - pcr - on - video - pid--new- audio - pes--demux--vbr--vbv - len = 500\\\\
            // \\\\A_AC3, "ПОЛНЫЙПУТЬКМТС.MTS", track = 4352\\\\

            // Шаг 4. запуcкаем файл tsmuxer.exe c параметрами и экстрактируем ауидо сдерствами демукса:
            // \\\\tsmuxer.exe "Путь к темповой папке\default.meta" "Путь выходной папки"\\\\
            // Ждем пока пройдет.

            // Шаг 5. Запихиваем mp4v (п2) и ac3 (п4) в .mp4 средствами мукса:
            // \\\\ MP4Box.exe -add "ПОЛНЫЙПУТЬДЛЯВИДЕО.track_4352.m4v:fps=13.534:delay=0:name=ИМЯЭТОГОВИДЕО.track_4352.m4v" -add "ПОЛНЫЙПУТЬКМТС.track_4352.ac3" -itags tool="My MP4Box GUI 0.6.0.6 <http://my-mp4box-gui.zymichost.com>" -new "ПУТЬКГОТОВОМУМУКСОМАННОМУ-muxed.mp4" \\\\
            //  Ждем пока пройдет.

            //Идем к шагу 1 для следующего файла.
            //    });

        }

    }
}
