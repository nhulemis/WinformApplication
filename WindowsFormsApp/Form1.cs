using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        NotificationManager notificationManager;
        public Form1()
        {
            InitializeComponent();

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
    }
}
