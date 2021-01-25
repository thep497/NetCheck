// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Class
//3. Unit Name:		AppConfig
//4. Programmer:	thep497
//5. Create date:	20210121
//6. Description:	Manage the program setting, using user.config (Properties.Settings.Default)
// *******************************************************************
// Revision : 1
// Edit history
// Rev 0: //th20210121 Initial this unit.
// Rev 1: //th20210125 เพิ่มการ save log
// *******************************************************************
namespace NNSClass
{
    public class AppConfig
    {
        public bool AppAutoStart { get => NetCheck.Properties.Settings.Default.AppAutoStart; set => NetCheck.Properties.Settings.Default.AppAutoStart = value; }
        public bool AutoSaveConfig { get => NetCheck.Properties.Settings.Default.AutoSaveConfig; set => NetCheck.Properties.Settings.Default.AutoSaveConfig = value; }
        public bool CheckWiredOnly { get => NetCheck.Properties.Settings.Default.CheckWiredOnly; set => NetCheck.Properties.Settings.Default.CheckWiredOnly = value; }
        public bool SaveLog { get => NetCheck.Properties.Settings.Default.SaveLog; set => NetCheck.Properties.Settings.Default.SaveLog = value; }
        public string TrayIconColor { get => NetCheck.Properties.Settings.Default.TrayIconColor; set => NetCheck.Properties.Settings.Default.TrayIconColor = value; }

        public string SmtpServer { get => NetCheck.Properties.Settings.Default.SmtpServer; set => NetCheck.Properties.Settings.Default.SmtpServer = value; }
        public int SmtpPort { get => NetCheck.Properties.Settings.Default.SmtpPort; set => NetCheck.Properties.Settings.Default.SmtpPort = value; }
        public string Username { get => NetCheck.Properties.Settings.Default.Username; set => NetCheck.Properties.Settings.Default.Username = value; }
        public string Password { get => NetCheck.Properties.Settings.Default.Password; set => NetCheck.Properties.Settings.Default.Password = value; }
        public string MailFrom { get => NetCheck.Properties.Settings.Default.MailFrom; set => NetCheck.Properties.Settings.Default.MailFrom = value; }
        public string MailTo { get => NetCheck.Properties.Settings.Default.MailTo; set => NetCheck.Properties.Settings.Default.MailTo = value; }

        public AppConfig()
        {
            //update user.config if needed
            if (NetCheck.Properties.Settings.Default.UpdateSettings)
            {
                NetCheck.Properties.Settings.Default.Upgrade();
                NetCheck.Properties.Settings.Default.UpdateSettings = false;
                NetCheck.Properties.Settings.Default.Save();
            }
        }
        public void Save(bool bypassCheckAutoSave = false)
        {
            if (AutoSaveConfig || bypassCheckAutoSave)
            {
                NetCheck.Properties.Settings.Default.Save();
            }
        }
    }
}
