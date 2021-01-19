using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class NotificationManager
    {
        static NotificationManager _instance;

        public List<Form_Alert> Form_Alerts;
        public bool HasDestroyNotif { get; set; }
        private int _countCurrentNotif;
        public int CountCurrentNotification
        {
            get { return _countCurrentNotif; }
            set
            {
                if (_countCurrentNotif > value)
                {
                    HasDestroyNotif = true;
                    ChangeIndexOfAlert();
                }
                _countCurrentNotif = value;
            }
        }

        private void ChangeIndexOfAlert()
        {
            if (Form_Alerts != null && Form_Alerts.Count > 0)
            {
                foreach (var item in Form_Alerts)
                {
                    item.Index--;
                }
            }
        }

        public static NotificationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotificationManager();
                }
                return _instance;
            }
        }
        private NotificationManager()
        {
            CountCurrentNotification = 0;
            HasDestroyNotif = false;
            Form_Alerts = new List<Form_Alert>();
        }

        public void RemoveAlert(Form_Alert frm)
        {
            Form_Alerts.Remove(frm);
            CountCurrentNotification--;
        }
    }
}
