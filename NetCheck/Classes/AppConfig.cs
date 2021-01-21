using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNSClass
{
    public class AppConfig
    {
        public bool AutoSaveConfig { get; set; }
        public bool CheckWiredOnly { get; set; }
        public string TrayIconColor { get; set; }

        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }

        public AppConfig()
        {
            Load();
        }

        public void Load()
        {
            this.AutoSaveConfig = NetCheck.Properties.Settings.Default.AutoSaveConfig;
            this.CheckWiredOnly = NetCheck.Properties.Settings.Default.CheckWiredOnly;
            this.TrayIconColor = NetCheck.Properties.Settings.Default.TrayIconColor;

            this.MailTo = NetCheck.Properties.Settings.Default.MailTo;
            this.MailFrom = NetCheck.Properties.Settings.Default.MailFrom;
            this.SmtpServer = NetCheck.Properties.Settings.Default.SmtpServer;
            this.SmtpPort = NetCheck.Properties.Settings.Default.SmtpPort;
            this.Username = NetCheck.Properties.Settings.Default.Username;
            this.Password = NetCheck.Properties.Settings.Default.Password.DecryptToString();
        }
        public void Save(bool bypassCheckAutoSave=false)
        {
            if (AutoSaveConfig || bypassCheckAutoSave)
            {
                NetCheck.Properties.Settings.Default.AutoSaveConfig = this.AutoSaveConfig;
                NetCheck.Properties.Settings.Default.CheckWiredOnly = this.CheckWiredOnly;
                NetCheck.Properties.Settings.Default.TrayIconColor = this.TrayIconColor;

                NetCheck.Properties.Settings.Default.MailTo = this.MailTo;
                NetCheck.Properties.Settings.Default.MailFrom = this.MailFrom;
                NetCheck.Properties.Settings.Default.SmtpServer = this.SmtpServer;
                NetCheck.Properties.Settings.Default.SmtpPort = this.SmtpPort;
                NetCheck.Properties.Settings.Default.Username = this.Username;
                NetCheck.Properties.Settings.Default.Password = this.Password.EncryptString(); 

                NetCheck.Properties.Settings.Default.Save();
            }
        }
    }
}
