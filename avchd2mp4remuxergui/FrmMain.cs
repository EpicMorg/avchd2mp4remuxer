using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avchd2mp4remuxergui
{
    public partial class FrmMain : Form
    {
        string pathToTools = Path.Combine(Application.StartupPath, "ffmpeg.exe");
        string pathToTsMuxer = Path.Combine(Application.StartupPath, "tsMuxeR.exe");
        string pathToFMp4Box = Path.Combine(Application.StartupPath, "MP4Box.exe");
        public FrmMain()
        {
            InitializeComponent(); 
        }
        private void CheckDeps()
        {
            if (File.Exists(pathToTools))
            {
                chkDepFFmpeg.Checked = true;
                chkDepFFmpeg.ForeColor = Color.GreenYellow;
            }
            else { 
                chkDepFFmpeg.Checked = false;
                chkDepFFmpeg.ForeColor = Color.Red;
            }
            if (File.Exists(pathToTsMuxer))
            {

            }
            if (File.Exists(pathToFMp4Box))
            {

            }


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CheckDeps();
        }

        private void chkDepFFmpeg_CheckedChanged(object sender, EventArgs e)
        {
            CheckDeps();
        }
    }
}
