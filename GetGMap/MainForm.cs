﻿using MapUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetGMap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i < 19; i++)
            //{
            //    int level = i;
            //    var lon = 113.6;
            //    var lat = 34.8;

            //    url = CGoogleImage.GetImageUrl(level, lon, lat);
            //    //webBrowser1.Url = new Uri(url);
            //    Image img = CGetImgByHttp.GetImage(url);
            //    pictureBox1.Image = img;
            //    string file = string.Format(@"C:\1\{0}.png", i);
            //    if (img!=null)
            //        img.Save(file, System.Drawing.Imaging.ImageFormat.Png);
            //}
            (new CGoogleImage(@"c:\1")).GetPicByRect(17, 113.371386, 30.405576, 113.549035, 30.314833);

        }



        public string url { get; set; }
    }
}
