using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtil
{
    public class CGoogleImage
    {
        static Dictionary<int, double> s_TdtScale = new Dictionary<int, double>(){
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
        const double c_topTileFromX = -20037508.3427892;
        const double c_topTileFromY = 20037508.3427892;
        static string dir = "http://mt3.google.cn/vt/lyrs=s&hl=zh-CN&gl=cn&";
        //var dir = "http://mt0.google.cn/vt/lyrs=m@167000000&hl=zh-CN&gl=cn&";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level">层级</param>
        /// <param name="lon">经度</param>
        /// <param name="lat">纬度</param>
        /// <returns></returns>
        public static string GetImageUrl(int level, double lon, double lat)
        {
            int xnum;
            int ynum;
            GetRowColIndex(level, lon, lat, out xnum, out ynum);
            return GetUrl(level, xnum, ynum);
        }

        private static string GetUrl(int level, int xnum, int ynum)
        {
            return dir + string.Format("x={0}&y={1}&z={2}", xnum, ynum, level);
        }

        /// <summary>
        /// 根据经纬度获取所在瓦片的行列号
        /// </summary>
        /// <param name="level"></param>
        /// <param name="lon"></param>
        /// <param name="lat"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public static void GetRowColIndex(int level, double lon, double lat, out int row, out int col)
        {
            row = 0;
            col = 0;
            double lon1 = CMercatorConversion.lon2Mercator(lon);
            double lat1 = CMercatorConversion.lat2Mercator(lat);
            var coef = s_TdtScale[level] * 256;
            row = (int)Math.Round((lon1 - c_topTileFromX) / coef);
            col = (int)Math.Round((c_topTileFromY - lat1) / coef);
        }

        public static void GetPicByRect(int level, double lonLeft, double latTop, double lonRight, double latBottom)
        {
            int rowStart;
            int colStart;
            int rowEnd;
            int colEnd;
            GetRowColIndex(level, lonLeft, latTop, out rowStart, out colEnd);
            GetRowColIndex(level, lonRight, latBottom, out rowEnd, out colStart);
            Image unionImg = new Bitmap(256 * (rowEnd + 1 - rowStart), 256 * (colEnd + 1 - colStart));
            Graphics g = Graphics.FromImage(unionImg);
            for (int i = rowStart; i <= rowEnd; i++)
            {
                for (int j = colStart; j <= colEnd; j++)
                {
                    string url = GetUrl(level,i, j);
                    Image img = CGetImgByHttp.GetImage(url);
                    string file = string.Format(@"C:\1\{0}+{1}.png", i,j);
                    if (img != null)
                    {
                        img.Save(file, System.Drawing.Imaging.ImageFormat.Png);
                        g.DrawImage(img, (i - rowStart) * 256, (j - colStart) * 256);
                    }
                }
            }
            g.Dispose();
            unionImg.Save(@"C:\1\union.png");
        }

    }
}
