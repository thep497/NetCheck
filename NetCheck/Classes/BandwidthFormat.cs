// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Class
//3. Unit Name:		BandwidthFormat
//4. Programmer:	thep497
//5. Create date:	20210121
//6. Description:	Extension function to format bandwith number to string (using the prefix Kbps, Mbps, Gbps, etc.)
// *******************************************************************
// Revision : 0
// Edit history
// Rev 0: //th20210121 Initial this unit.
// *******************************************************************
using System;

namespace NNSClass
{
    public static class BandwidthFormat
    {
        public static string[] ordinals = new[] { "", "K", "M", "G", "T", "P", "E" };
        public static string ToBWString(this long bandwidth_bps, bool is_XiB = false)
        {
            var _10x3 = is_XiB ? 1024 : 1000;
            decimal rate = (decimal)bandwidth_bps;
            var ordinal = 0;

            while (rate >= _10x3)
            {
                rate /= _10x3;
                ordinal++;
            }

            return (String.Format("{0:0.0} {1}bps",
                    Math.Round(rate, 1, MidpointRounding.AwayFromZero),
                    ordinals[ordinal]));
        }
    }
}
