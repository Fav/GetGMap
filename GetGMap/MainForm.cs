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
        string _pathDir;

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
                label1.Text = string.Format("{0}/{1}", index, sum);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pathDir) || !Directory.Exists(_pathDir))
            {
                OutWarning("路径不能为空");
                return;
            }
            List<int> lstLevel = GetLevel();
            tsslWarning.Text = "";


            Thread t = new Thread(StartDownload) { IsBackground = true };
            t.Start();
        }

        private List<int> GetLevel()
        {
            throw new NotImplementedException();
        }

        private void OutWarning(string p)
        {
            throw new NotImplementedException();
        }
        CGoogleImage img = new CGoogleImage(@"c:\1");
        // 开始下载
        public void StartDownload()
        {
            img.ProcessInfo += img_ProcessInfo;
            //for (int i = 1; i <= 16; i++)
            //{
            //    img.GetPicByRect(i, 113.371386, 30.405576, 113.549035, 30.314833);
            //}
            img.SavePicByRect(20, 113.371386, 30.405576, 113.549035, 30.314833);
            MessageBox.Show("完成");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            tbPathDir.Text = dlg.SelectedPath;
            _pathDir = tbPathDir.Text;
        } 
    }
}
