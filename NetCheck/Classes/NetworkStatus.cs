//************************************************************************************************
// Copyright © 2010 Steven M. Cohn. All Rights Reserved.
//
//************************************************************************************************

namespace NNSClass
{
	using System;
	using System.Collections.Generic;
	using System.Net.NetworkInformation;
	using System.Runtime.CompilerServices;


    /// <summary>
    /// Provides notification of status changes related to Internet-specific network
    /// adapters on this machine.  All other adpaters such as tunneling and loopbacks
    /// are ignored.  Only connected IP adapters are considered.
    /// </summary>
    /// <remarks>
    /// <i>Implementation Note:</i>
    /// <para>
    /// Since we'll likely invoke the IsAvailable property very frequently, that should
    /// be very efficient.  So we wire up handlers for both NetworkAvailabilityChanged
    /// and NetworkAddressChanged and capture the state in the local isAvailable variable. 
    /// </para>
    /// </remarks>

    public class NetworkStatus
    {
        private bool isAvailable;
        private long netSpeed;
        private string ifaceName;
        private NetworkStatusChangedHandler handler;
        private bool checkWiredEthernetOnly;

        //========================================================================================
        // Constructor
        //========================================================================================

        /// <summary>
        /// Initialize the class by detecting the start condition.
        /// </summary>

        public NetworkStatus()
        {
            isAvailable = IsNetworkAvailable();
        }


        //========================================================================================
        // Properties
        //========================================================================================

        /// <summary>
        /// This event is fired when the overall Internet connectivity changes.  All
        /// non-Internet adpaters are ignored.  If at least one valid Internet connection
        /// is "up" then we consider the Internet "available".
        /// </summary>

        public event NetworkStatusChangedHandler AvailabilityChanged
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                if (handler == null)
                {
                    NetworkChange.NetworkAvailabilityChanged
                        += new NetworkAvailabilityChangedEventHandler(DoNetworkAvailabilityChanged);

                    NetworkChange.NetworkAddressChanged
                        += new NetworkAddressChangedEventHandler(DoNetworkAddressChanged);
                }

                handler = (NetworkStatusChangedHandler)Delegate.Combine(handler, value);
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                handler = (NetworkStatusChangedHandler)Delegate.Remove(handler, value);

                if (handler == null)
                {
                    NetworkChange.NetworkAvailabilityChanged
                        -= new NetworkAvailabilityChangedEventHandler(DoNetworkAvailabilityChanged);

                    NetworkChange.NetworkAddressChanged
                        -= new NetworkAddressChangedEventHandler(DoNetworkAddressChanged);
                }
            }
        }


        /// <summary>
        /// Gets a Boolean value indicating the current state of Internet connectivity.
        /// </summary>

        public bool IsAvailable => isAvailable;
        public long NetSpeed => netSpeed;
        public string InterfaceName => ifaceName;
        public bool CheckWiredOnly { get => checkWiredEthernetOnly; set { checkWiredEthernetOnly = value; SignalAvailabilityChange(this); } }

        private bool IsNetworkAvailable()
        {
            // only recognizes changes related to Internet adapters
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                var checkTypeOptions = new List<NetworkInterfaceType>();
                if (checkWiredEthernetOnly)
                {
                    checkTypeOptions.Add(NetworkInterfaceType.Ethernet);
                    checkTypeOptions.Add(NetworkInterfaceType.GigabitEthernet);
                    checkTypeOptions.Add(NetworkInterfaceType.FastEthernetT);
                    checkTypeOptions.Add(NetworkInterfaceType.FastEthernetFx);
                    //checkTypeOptions.Add(NetworkInterfaceType.Wireless80211); //This is wifi
                }

                // however, this will include all adapters
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface face in interfaces)
                {
                    // filter so we see only Internet adapters
                    if (face.OperationalStatus == OperationalStatus.Up)
                    {
                        if ((face.NetworkInterfaceType != NetworkInterfaceType.Tunnel) &&
                            (face.NetworkInterfaceType != NetworkInterfaceType.Loopback) &&
                            (!checkWiredEthernetOnly || checkTypeOptions.Contains(face.NetworkInterfaceType)))
                        {
                            IPv4InterfaceStatistics statistics = face.GetIPv4Statistics();

                            // all testing seems to prove that once an interface comes online
                            // it has already accrued statistics for both received and sent...

                            if ((statistics.BytesReceived > 0) &&
                                (statistics.BytesSent > 0))
                            {
                                netSpeed = face.Speed;
                                ifaceName = face.Name;
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void DoNetworkAddressChanged(object sender, EventArgs e)
        {
            SignalAvailabilityChange(sender);
        }

        private void DoNetworkAvailabilityChanged(
            object sender, NetworkAvailabilityEventArgs e)
        {
            SignalAvailabilityChange(sender);
        }

        private void SignalAvailabilityChange(object sender)
        {
            bool change = IsNetworkAvailable();

            if (change != isAvailable)
            {
                isAvailable = change;

                //	if (handler != null)
                //	{
                //		handler(sender, new NetworkStatusChangedArgs(isAvailable));
                //	}
            }

            if (handler != null)
            {
                handler(sender, new NetworkStatusChangedArgs(isAvailable));
            }
        }
    }
}