// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Class
//3. Unit Name:		NetworkStatusChangedArgs
//4. Programmer:	thep497
//5. Create date:	20210121
//6. Description:	Helper class to check network status
//                  Copyright © 2010 Steven M. Cohn. All Rights Reserved.
// *******************************************************************
// Revision : 0
// Edit history
// Rev 0: //th20210121 Initial this unit.
// *******************************************************************
namespace NNSClass
{
	using System;


	//********************************************************************************************
	// class NetworkStatusChangedArgs
	//********************************************************************************************

	/// <summary>
	/// Describes the overall network connectivity of the machine.
	/// </summary>

	public class NetworkStatusChangedArgs : EventArgs
	{
		private bool isAvailable;


		/// <summary>
		/// Instantiate a new instance with the given availability.
		/// </summary>
		/// <param name="isAvailable"></param>

		public NetworkStatusChangedArgs (bool isAvailable)
		{
			this.isAvailable = isAvailable;
		}


		/// <summary>
		/// Gets a Boolean value indicating the current state of Internet connectivity.
		/// </summary>

		public bool IsAvailable
		{
			get { return isAvailable; }
		}
	}


	//********************************************************************************************
	// delegate NetworkStatusChangedHandler
	//********************************************************************************************

	/// <summary>
	/// Define the method signature for network status changes.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

	public delegate void NetworkStatusChangedHandler (
		object sender, NetworkStatusChangedArgs e);
}
