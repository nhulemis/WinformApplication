using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        NotificationManager notificationManager;
        public Form1()
        {
            InitializeComponent();
           // this.Cursor = new Cursor(Properties.Resources.icons8_cursor_25px_2.GetHicon());
            notificationManager = NotificationManager.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Alert alert = new Form_Alert();
            alert.ShowNotifi();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonChart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void iconButtonChart_MouseLeave(object sender, EventArgs e)
        {
            var pad = iconButtonChart.Padding;
            pad.Left -= 10;
            iconButtonChart.Padding = pad;
        }

        private void iconButtonChart_MouseEnter(object sender, EventArgs e)
        {
            var pad = iconButtonChart.Padding;
            pad.Left += 10;
            iconButtonChart.Padding = pad;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonSettings_MouseEnter(object sender, EventArgs e)
        {
            var pad = iconButtonSettings.Padding;
            pad.Left += 10;
            iconButtonSettings.Padding = pad;
        }

        private void iconButtonSettings_MouseLeave(object sender, EventArgs e)
        {
            var pad = iconButtonSettings.Padding;
            pad.Left -= 10;
            iconButtonSettings.Padding = pad;
        }

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelBar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panelBar_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
