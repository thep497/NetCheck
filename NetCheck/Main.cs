// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Main
//3. Unit Name:		Main
//4. Programmer:	thep497
//5. Create date:	20210121
//6. Description:	Main popup menu and config form
// *******************************************************************
// Revision : 0
// Edit history
// Rev 0: //th20210121 Initial this unit.
// Rev 1: //th20210121 Fix small bugs.
// *******************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetCheck
{
    using Microsoft.Win32;
    using NNSClass;

    public partial class Main : Form
	{
		private NetworkStatus nwStatus = new NetworkStatus();
		private AppConfig appConfig = new AppConfig();
		private bool _configDirty = false;

		private bool configDirty { get => _configDirty; set { _configDirty = lblDirty.Visible = value; } }

		public Main()
		{
			InitializeComponent();

			mnuRunAtStart.Checked = appConfig.AppAutoStart;
			nwStatus.CheckWiredOnly = appConfig.CheckWiredOnly;
			nwStatus.AvailabilityChanged +=
				new NetworkStatusChangedHandler(DoAvailabilityChanged);

			//th20210121 ไม่จำเป็นมั้ง loadConfigToControl();
		}

        #region Form Events
        private void Main_Load(object sender, EventArgs e)
		{
			changeTrayIconColor(appConfig.TrayIconColor); //ReportAvailability();

			this.WindowState = FormWindowState.Minimized;
			minimizedToTray();
		}
		private void Main_Move(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
				minimizedToTray();
		}
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				minimizedToTray();
				e.Cancel = true;
			}
		}
		private void mnuExit_Click(object sender, EventArgs e)
		{
			saveConfigFromControl();
			Application.Exit();
		}

		private void mnuConfig_Click(object sender, EventArgs e)
		{
			showConfigForm();
		}
		private void mnuChangeAdapterOptions_Click(object sender, EventArgs e)
		{
			changeAdapterOptions(); 
		}
		private void mnuWhite_Click(object sender, EventArgs e)
		{
			var menu = (ToolStripMenuItem)sender;
			changeTrayIconColor(menu.Text);
		}
		private void mnuRunAtStart_Click(object sender, EventArgs e)
		{
			RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			var regKey = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath);
			var menu = (ToolStripMenuItem)sender;
			if (menu.Checked)
			{
				rkApp.SetValue(regKey, Application.ExecutablePath.ToString());
			}
			else
			{
				rkApp.DeleteValue(regKey, false);
			}
			appConfig.AppAutoStart = mnuRunAtStart.Checked;
			appConfig.Save(true);
		}
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//showConfigForm();
			changeAdapterOptions();
		}
		private void btSave_Click(object sender, EventArgs e)
		{
			saveConfigFromControl(true);
		}
		private void cbAutoSaveConfig_Click(object sender, EventArgs e)
		{
			btSave.Visible = !cbAutoSaveConfig.Checked;
		}
		private void tbMailTo_TextChanged(object sender, EventArgs e)
		{
			configDirty = true;
		}
		#endregion

		#region Private functions
		private void minimizedToTray()
		{
			this.ShowInTaskbar = false;
			this.Hide();
			this.notifyIcon1.Visible = true;
			//th20210121 เยอะไป ไม่แสดงเลยดีกว่า this.notifyIcon1.ShowBalloonTip(100, "Status", "Program is running in the background...", ToolTipIcon.Info);

			saveConfigFromControl();
			destroyPasswordInControl();
		}
		private void showConfigForm()
		{
			loadConfigToControl();
			this.Show();
			this.ShowInTaskbar = true; //th20210121 show in taskbar when show config
			this.WindowState = FormWindowState.Normal;
		}
		private void changeAdapterOptions()
        {
			System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL ncpa.cpl,,1");
		}
		private void destroyPasswordInControl()
		{
			tbPassword.Text = "";
			configDirty = false;
		}
		private void loadConfigToControl()
		{
			cbAutoSaveConfig.Checked = appConfig.AutoSaveConfig;
			cbWiredOnly.Checked = appConfig.CheckWiredOnly;
			tbMailTo.Text = appConfig.MailTo;

			tbSMTPServer.Text = appConfig.SmtpServer;
			nmSMTPPort.Value = appConfig.SmtpPort;
			tbUserName.Text = appConfig.Username;
			tbPassword.Text = appConfig.Password.DecryptToString();
			tbMailFrom.Text = appConfig.MailFrom;

			btSave.Visible = !cbAutoSaveConfig.Checked;
			configDirty = false;
		}
		private void saveConfigFromControl(bool bypassCheckAutoSave = false)
		{
			if (configDirty) // || bypassCheckAutoSave ไม่น่าจะต้องมี ถ้าไม่มีแก้จะ save ทำไม
			{
				appConfig.AutoSaveConfig = cbAutoSaveConfig.Checked;
				appConfig.CheckWiredOnly = cbWiredOnly.Checked;
				appConfig.MailTo = tbMailTo.Text;

				appConfig.SmtpServer = tbSMTPServer.Text;
				appConfig.SmtpPort = (int)nmSMTPPort.Value;
				appConfig.Username = tbUserName.Text;
				appConfig.Password = tbPassword.Text.EncryptString();
				appConfig.MailFrom = tbMailFrom.Text;

				appConfig.Save(bypassCheckAutoSave);
			}
			configDirty = false;
		}
		private bool sendEMail(bool IsAvailable)
		{
			var mSender = new MailSender(appConfig.SmtpServer, appConfig.SmtpPort, appConfig.Username, appConfig.Password.DecryptToString(),
										 appConfig.MailFrom, appConfig.MailTo,
										 string.Format("Net Check Status ({0})",IsAvailable ? "Connected" : "Disconnected"),
										 string.Format("{0}\nFrom: {1}", lblStatus.Text, Environment.MachineName));
			if (mSender.CanSendMail)
				return mSender.SendMail();

			return true;
		}
		private Icon iconConnected = Properties.Resources.Connected;
		private Icon iconDisconnected = Properties.Resources.Disconnected;
		private void changeTrayIconColor(string tiColor)
		{
			if (appConfig.TrayIconColor != tiColor)
			{
				appConfig.TrayIconColor = tiColor;
				appConfig.Save(true);
			}
			mnuYellow.Checked = false; mnuWhite.Checked = false; mnuBlack.Checked = false;
			switch (appConfig.TrayIconColor.ToLower())
			{
				case "white":
					iconConnected = Properties.Resources.ConnectedW;
					iconDisconnected = Properties.Resources.DisconnectedW;
					mnuWhite.Checked = true;
					break;
				case "black":
					iconConnected = Properties.Resources.ConnectedB;
					iconDisconnected = Properties.Resources.DisconnectedB;
					mnuBlack.Checked = true;
					break;
				default:
					iconConnected = Properties.Resources.Connected;
					iconDisconnected = Properties.Resources.Disconnected;
					mnuYellow.Checked = true;
					break;
			}
			ReportAvailability(); //must be out of if to show the status
		}
		#endregion

		#region Network Checking....
		/// <summary>
		/// Event handler used to capture availability changes.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void DoAvailabilityChanged(
			object sender, NetworkStatusChangedArgs e)
		{
			ReportAvailability();
		}

		private delegate void myDelegate(string myText);

		/// <summary>
		/// Report the current network availability.
		/// </summary>
		private void ReportAvailability()
		{
			var networkStatusString = "";
			if (nwStatus.IsAvailable)
			{
				networkStatusString = string.Format("Connected @ {0}\n{1}", nwStatus.NetSpeed.ToBWString(), nwStatus.InterfaceName);
				notifyIcon1.Icon = iconConnected;
			}
			else
			{
				networkStatusString = "Disconnected";
				notifyIcon1.Icon = iconDisconnected;
			}

			lblStatus.BeginInvoke(new myDelegate(DelegateMethod), networkStatusString);

			if (notifyIcon1.Text != networkStatusString)
			{
				if (notifyIcon1.Text != "")
				{
					notifyIcon1.ShowBalloonTip(100, "Network", "Network status changed to:\n" + networkStatusString, nwStatus.IsAvailable ? ToolTipIcon.Info : ToolTipIcon.Warning);
					if (!sendEMail(nwStatus.IsAvailable))
						notifyIcon1.ShowBalloonTip(100, "e-Mail", "Sending mail failed...", ToolTipIcon.Warning);
				}
				notifyIcon1.Text = networkStatusString;
			}
		}

		private void DelegateMethod(string myText)
		{
			lblStatus.Text = myText;
		}
        #endregion

    }
}
