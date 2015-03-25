using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGMap
{
    public class GoogleImage
    {
       static Dictionary<int, double> tdtScale = new Dictionary<int, double>(){
		        {18,0.597164283559817},
		        {17,1.19432856685505},
		        {16,2.38865713397468},
		        {15,4.77731426794937},
		        {14,9.55462853563415},
		        {13,19.1092570712683},
		        {12,38.2185141425366},
		        {11,76.4370282850732},
		        {10,152.8740565704},
		        {9,305.7481128},
		        {8,611.49622628138},
		        {7,1222.99245256249},
		        {6,2445.98490512499},
		        {5,4891.96981024998},
		        {4,9783.93962049996},
		        {3,19567.8792409999},
		        {2,39135.7584820001},
		        {1,78271.5169639999}};
        /// <summary>
        /// 
        /// </summary>
        /// <param name="level">层级</param>
        /// <param name="lon">经度</param>
        /// <param name="lat">纬度</param>
        /// <returns></returns>
        public static string GetImageUrl(int level,double lon,double lat )
        {
            var topTileFromX = -20037508.3427892;
            var topTileFromY = 20037508.3427892;

            double lon1 = lon2Mercator(lon);
            double lat1 = lat2Mercator(lat);

            var coef = tdtScale[level] * 256;

            int x_num = (int)Math.Round((lon1 - topTileFromX) / coef);
            int y_num = (int)Math.Round((topTileFromY - lat1) / coef);

            //var dir = "http://mt0.google.cn/vt/lyrs=m@167000000&hl=zh-CN&gl=cn&";
            var dir = "http://mt3.google.cn/vt/lyrs=s&hl=zh-CN&gl=cn&";
            var server =string.Format( "x={0}&y={1}&z={2}",x_num,y_num,level);
            var imageDir = dir + server;

            return imageDir;
        }
        private string String<T>(T t)
        {
            return t.ToString();
        }

        private static double lon2Mercator(double px)
        {
            double x = px * 20037508.3427892 / 180;
            return x;
        }

        private static double lat2Mercator(double py)
        {
            double y;
            y = Math.Log(Math.Tan((90 + py) * Math.PI / 360)) / (Math.PI / 180);
            y = y * 20037508.3427892 / 180;
            return y;
        }


    }
}
