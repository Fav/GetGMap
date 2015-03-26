using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtil
{
    public class CMercatorConversion
    {
        public static double lon2Mercator(double px)
        {
            double x = px * 20037508.3427892 / 180;
            return x;
        }

        public static double lat2Mercator(double py)
        {
            double y;
            y = Math.Log(Math.Tan((90 + py) * Math.PI / 360)) / (Math.PI / 180);
            y = y * 20037508.3427892 / 180;
            return y;
        }
    }
}
