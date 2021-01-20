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
            AutoSaveConfig = NetCheck.Properties.Settings.Default.AutoSaveConfig;
            CheckWiredOnly = NetCheck.Properties.Settings.Default.CheckWiredOnly;
            MailTo = NetCheck.Properties.Settings.Default.MailTo;
            MailFrom = NetCheck.Properties.Settings.Default.MailFrom;
            SmtpServer = NetCheck.Properties.Settings.Default.SmtpServer;
            SmtpPort = NetCheck.Properties.Settings.Default.SmtpPort;
            Username = NetCheck.Properties.Settings.Default.Username;
            Password = NetCheck.Properties.Settings.Default.Password;
        }
        public void Save(bool bypassCheckAutoSave=false)
        {
            if (AutoSaveConfig || bypassCheckAutoSave)
            {
                NetCheck.Properties.Settings.Default.AutoSaveConfig = AutoSaveConfig;
                NetCheck.Properties.Settings.Default.CheckWiredOnly = CheckWiredOnly;
                NetCheck.Properties.Settings.Default.MailTo = MailTo;
                NetCheck.Properties.Settings.Default.MailFrom = MailFrom;
                NetCheck.Properties.Settings.Default.SmtpServer = SmtpServer;
                NetCheck.Properties.Settings.Default.SmtpPort = SmtpPort;
                NetCheck.Properties.Settings.Default.Username = Username;
                NetCheck.Properties.Settings.Default.Password = Password;

                NetCheck.Properties.Settings.Default.Save();
            }
        }
    }
}
