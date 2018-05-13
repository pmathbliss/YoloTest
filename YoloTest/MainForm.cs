using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoloTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            YoloTest.Model.IBasic basic = new YoloTest.Model.Structures.FaceDetection();
            basic.ImageLocation = txtFileLocation.Text;
            basic.Run();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var selected = ofdBrowseFile.ShowDialog();

            if(selected == DialogResult.OK)
            {
                txtFileLocation.Text = ofdBrowseFile.FileName;
            }
        }
    }
}
