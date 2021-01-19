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
    public partial class Form_Alert : Form
    {
        public int Index { get; set; }
        private int x , y , newPosY;

        NotificationManager notificationManager;

        public Form_Alert()
        {
            notificationManager = NotificationManager.Instance;
            InitializeComponent();
        }

        public enum AlertState
        {
            Start,
            Wait,
            Close
        }

        AlertState state;

        private void InitAlert()
        {
            this.Opacity = 0f;
            this.StartPosition = FormStartPosition.Manual;
            string fname = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                fname = $"Notifi{i}" ;

                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];
                if (frm == null)
                {
                    this.Index = i;
                    this.Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - this.Width ;
                    y = Screen.PrimaryScreen.WorkingArea.Height -this.Height * (i + 1);
                    this.Location = new Point(x, y);
                    notificationManager.Form_Alerts.Add(this);
                    break;
                }
            }
            state = AlertState.Start;
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 15;
        }

        internal void ShowNotifi()
        {
            InitAlert();
            notificationManager.CountCurrentNotification++;
            this.Show();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (state)
            {
                case AlertState.Start:
                    timer1.Interval = 1;
                    this.Opacity += 0.05f;
                    if (this.x < Location.X )
                    {
                        this.Left-=2;
                    }
                    else
                    {
                        if (Opacity >= .8f)
                        {
                            state = AlertState.Wait;
                        }
                    }
                    break;
                case AlertState.Wait:
                    timer1.Interval = 2000;
                    state = AlertState.Close;
                    break;
                case AlertState.Close:
                    timer1.Interval = 1;
                    Opacity -= 0.05f;
                    this.Left -= 3;
                    if (Opacity == 0)
                    {
                        notificationManager.RemoveAlert(this);
                        base.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
