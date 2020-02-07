using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Amish
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
