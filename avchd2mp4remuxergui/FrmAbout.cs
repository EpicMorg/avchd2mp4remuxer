using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace avchd2mp4remuxergui
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }
        public string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblVer.Text = Application.ProductVersion; 
            lblName.Text = Application.ProductName;
            lblCopy.Text = AssemblyCopyright; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
