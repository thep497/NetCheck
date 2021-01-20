using System;
using System.Collections.Generic;
using System.Text;

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
