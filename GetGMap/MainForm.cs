using MapUtil;
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
        public string url { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        void img_ProcessInfo(int sum, int index)
        {
            if (this.InvokeRequired&& !this.IsDisposed &&this.IsHandleCreated)
            {
                //只是不抛出异常了  BeginInvoke
                 this.BeginInvoke(new CGoogleImage.ProcessInfoHandler(img_ProcessInfo), new object[] { sum, index });
            }
            else
            {
                progressBar1.Maximum = sum;
                progressBar1.Value = index;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(StartDownload) { IsBackground = true };
            t.Start();
        }
        CGoogleImage img = new CGoogleImage(@"c:\1");
        // 开始下载
        public void StartDownload()
        {
            img.ProcessInfo += img_ProcessInfo;
            img.GetPicByRect(12, 113.371386, 30.405576, 113.549035, 30.314833);
        } 
    }
}
