using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NetCheck
{
	using NNSClass;

	public partial class Main : Form
	{
		private NetworkStatus nwStatus = new NetworkStatus();
		private AppConfig appConfig = new AppConfig();

		public Main()
		{
			InitializeComponent();

			nwStatus.CheckWiredOnly = appConfig.CheckWiredOnly;
			nwStatus.AvailabilityChanged +=
				new NetworkStatusChangedHandler(DoAvailabilityChanged);

			loadConfigToControl();
		}

        #region Form Events
        private void Main_Load(object sender, EventArgs e)
		{
			ReportAvailability();

			this.WindowState = FormWindowState.Minimized;
			minimizedToTray();
		}
		private void Main_Move(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				minimizedToTray();
			}
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
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//showConfigForm();
			changeAdapterOptions();
		}
		private void btSave_Click(object sender, EventArgs e)
		{
			saveConfigFromControl(true);
		}
		#endregion

		#region Private functions
		private void minimizedToTray()
		{
			this.ShowInTaskbar = false;
			this.Hide();
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.ShowBalloonTip(100, "Running", "Program is running in the background...", ToolTipIcon.Info);

			saveConfigFromControl();
		}
		private void showConfigForm()
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}
		private void changeAdapterOptions()
        {
			System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL ncpa.cpl,,1");
		}
		private void loadConfigToControl()
		{
			cbAutoSaveConfig.Checked = appConfig.AutoSaveConfig;
			cbWiredOnly.Checked = appConfig.CheckWiredOnly;
			tbMailTo.Text = appConfig.MailTo;
		}
		private void saveConfigFromControl(bool bypassCheckAutoSave = false)
		{
			appConfig.AutoSaveConfig = cbAutoSaveConfig.Checked;
			appConfig.CheckWiredOnly = cbWiredOnly.Checked;
			appConfig.MailTo = tbMailTo.Text;

			appConfig.Save(bypassCheckAutoSave);
		}
		private void sendEMail()
		{
			var mSender = new MailSender(appConfig.SmtpServer, appConfig.SmtpPort, appConfig.Username, appConfig.Password,
										 appConfig.MailFrom, appConfig.MailTo,
										 "Net Check Status",
										 string.Format("{0}\nFrom: {1}", lblStatus.Text, Environment.MachineName));
			if (mSender.CanSendMail)
				mSender.SendMail();
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

		/// <summary>
		/// Report the current network availability.
		/// </summary>
		private delegate void MyDelegate(string myText);
		private void ReportAvailability()
		{
			var networkStatusString = "";
			if (nwStatus.IsAvailable)
			{
				networkStatusString = string.Format("Connected @ {0}\n{1}", nwStatus.NetSpeed.ToBWString(), nwStatus.InterfaceName);
				notifyIcon1.Icon = Properties.Resources.Connected;
			}
			else
			{
				networkStatusString = "Disconnected";
				notifyIcon1.Icon = Properties.Resources.Disconnected;
			}

			lblStatus.BeginInvoke(new MyDelegate(DelegateMethod), networkStatusString);

			if (notifyIcon1.Text != networkStatusString)
			{
				if (notifyIcon1.Text != "")
				{
					notifyIcon1.ShowBalloonTip(100, "Status", "Network status changed to:\n" + networkStatusString, nwStatus.IsAvailable ? ToolTipIcon.Info : ToolTipIcon.Warning);
					sendEMail();
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
