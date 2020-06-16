using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CupHolder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
    }
}
