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
	using iTuner;

	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			NetworkStatus.AvailabilityChanged +=
				new NetworkStatusChangedHandler(DoAvailabilityChanged);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			ReportAvailability();
		}
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
			if (NetworkStatus.IsAvailable)
				label1.BeginInvoke(new MyDelegate(DelegateMethod),"On @ "+NetworkStatus.NetSpeed.ToBWString()); 
			else
				label1.BeginInvoke(new MyDelegate(DelegateMethod), "Off");
		}

		private void DelegateMethod(string myText)
		{
			label1.Text = myText;
		}

	}
}
