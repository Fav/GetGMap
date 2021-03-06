﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtil
{
    public class CGoogleImage
    {
        public delegate void ProcessInfoHandler(int level, int sum,int index);
        public event ProcessInfoHandler  ProcessInfo;

        static Dictionary<int, double> s_TdtScale = new Dictionary<int, double>(){
		        {20,0.149291071},
		        {19,0.298582142},
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
		        {1,78271.5169639999},
                {0,156543.0339}
        };
        const double c_topTileFromX = -20037508.3427892;
        const double c_topTileFromY = 20037508.3427892;

        const int c_limitWidth = 12800; //bitmap尺寸有限制，这里设置成12800
        const int c_sidelength = 256;
        static string dir = "http://mt3.google.cn/vt/lyrs=s&hl=zh-CN&gl=cn&";
        //var dir = "http://mt0.google.cn/vt/lyrs=m@167000000&hl=zh-CN&gl=cn&";


        string fileDir = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filedir">图片保存的目录</param>
        public CGoogleImage(string filedir)
        {
            if (Directory.Exists(filedir))
            {
                Directory.CreateDirectory(filedir);
            }
            fileDir = filedir;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="level">层级</param>
        /// <param name="lon">经度</param>
        /// <param name="lat">纬度</param>
        /// <returns></returns>
        public string GetImageUrl(int level, double lon, double lat)
        {
            int xnum;
            int ynum;
            GetRowColIndex(level, lon, lat, out xnum, out ynum);
            return GetUrl(level, xnum, ynum);
        }

        private string GetUrl(int level, int xnum, int ynum)
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
        public void GetRowColIndex(int level, double lon, double lat, out int row, out int col)
        {
            row = 0;
            col = 0;
            double lon1 = CMercatorConversion.lon2Mercator(lon);
            double lat1 = CMercatorConversion.lat2Mercator(lat);
            var coef = s_TdtScale[level] * 256;
            row = (int)Math.Round((lon1 - c_topTileFromX) / coef);
            col = (int)Math.Round((c_topTileFromY - lat1) / coef);
        }

        public void SavePicByRect(int level, double lonLeft, double latTop, double lonRight, double latBottom)
        {
            int rowStart;
            int colStart;
            int rowEnd;
            int colEnd;
            int x1;
            int y1;
            int x2;
            int y2;
            GetRowColIndex(level, lonLeft, latTop, out x1, out y1);
            GetRowColIndex(level, lonRight, latBottom, out x2, out y2);
            rowStart = Math.Min(x1, x2);
            rowEnd = Math.Max(x1, x2);
            colStart = Math.Min(y1, y2);
            colEnd = Math.Max(y1, y2);
            Image unionImg = null;
            try
            {
                int width = c_sidelength * (rowEnd + 1 - rowStart);
                if (width >c_limitWidth)
                {
                    width = c_limitWidth;
                    rowEnd = c_limitWidth / c_sidelength + rowStart - 1;
                }
                int height =  c_sidelength * (colEnd + 1 - colStart);
                if (height >c_limitWidth)
                {
                    height = c_limitWidth;
                    colEnd = c_limitWidth / c_sidelength + colStart - 1;
                }
                unionImg = new Bitmap(width, height);
            }
            catch{}
            if (unionImg == null)
            {
                return;
            }
            Graphics g = Graphics.FromImage(unionImg);
            int countInRow =  rowEnd-rowStart+1;//一行有多少瓦片
            int countRow = colEnd-colStart+1;   //有多少行
            int sum = countInRow * countRow;
            OutLog(DateTime.Now.ToString() + " 错误瓦片行列号：");
            for (int j = colStart; j <= colEnd; j++)
            {
                for (int i = rowStart; i <= rowEnd; i++)
                {
                    string url = GetUrl(level, i, j);
                    Image img = CGetImgByHttp.GetImage(url);
                    string file = string.Format(@"{0}\{1}+{2}.png", fileDir,i, j);
                    if (img != null)
                    {
                        //img.Save(file, System.Drawing.Imaging.ImageFormat.Png);
                        g.DrawImage(img, (i - rowStart) * 256, (j - colStart) * 256);
                        img.Dispose();
                    }
                    else
                    {
                        //输出下载出错信息
                        OutLog(string.Format("{0},{1}",i,j));
                    }
                    if (ProcessInfo!=null)
                        ProcessInfo(level,sum, countInRow * (j - colStart) + i - rowStart + 1);
                }
            }
            g.Dispose();
            unionImg.Save(string.Format( @"{0}\union{1}.png", fileDir,level));
            unionImg.Dispose();
            OutLog( "下载结束\r\n");

        }

        private void SaveOnePic(int level, int i, int j)
        {
            throw new NotImplementedException();
        }

        private void OutLog(string p)
        {
            using (StreamWriter  sw = new StreamWriter (string.Format( @"{0}\log.txt", fileDir),true))
            {
                sw.WriteLine(p);
            }
        }

    }
}
