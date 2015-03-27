using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MapUtil
{
   public class CGetImgByHttp
    {
        public static Image GetImage(string url)
        {
            Image img = null;
            try
            {
                HttpWebRequest MyHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                MyHttpWebRequest.Accept = "*/*";
                MyHttpWebRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "png, deflate");
                MyHttpWebRequest.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN");
                MyHttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E)";
                MyHttpWebRequest.Timeout = 2000;
                HttpWebResponse resp = (HttpWebResponse)MyHttpWebRequest.GetResponse();
                Stream stream = resp.GetResponseStream();
                img = Image.FromStream(stream);
            }
            catch  {}
            return img;
        }
    }
}
