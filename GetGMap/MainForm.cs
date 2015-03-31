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

        void img_ProcessInfo(int level,int sum, int index)
        {
            if (this.InvokeRequired&& !this.IsDisposed &&this.IsHandleCreated)
            {
                //只是不抛出异常了  BeginInvoke
                 this.BeginInvoke(new CGoogleImage.ProcessInfoHandler(img_ProcessInfo), new object[] {level, sum, index });
            }
            else
            {
                progressBar1.Maximum = sum;
                progressBar1.Value = index;
                label1.Text = string.Format("第{0}级:{1}/{2}", level, index, sum);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pathDir) || !Directory.Exists(_pathDir))
            {
                OutWarning("路径不能为空");
                return;
            }
            lstLevel = GetLevel();
            if (lstLevel.Count==0)
            {
                OutWarning("请选择下载的等级");
                return;
            }
            if ( !CheckPoint(tbPoint1.Text,out x1,out y1))
            {
                OutWarning("左上角经纬度坐标错误");
                return;
            }
            if (!CheckPoint(tbPoint2.Text, out x2, out y2))
            {
                OutWarning("右下角经纬度坐标错误");
                return;
            }
            tsslWarning.Text = "";
            img = new CGoogleImage(_pathDir);
            Thread t = new Thread(StartDownload) { IsBackground = true };
            t.Start();
        }
        double x1, x2, y1, y2;
        List<int> lstLevel = new List<int>();
        private bool CheckPoint(string p,out double x,out double y)
        {
            x = 0d;
            y = 0d;
            if (string.IsNullOrEmpty(p))
                return false;
            try
            {
                string[] str = p.Split(',');
                if (str.Length != 2)
                    return false;
                double.TryParse(str[0], out x);
                double.TryParse(str[1], out y);
            }
            catch
            {
                return false;   
            }
            return true;
        }

        private List<int> GetLevel()
        {
            List<int> lst = new List<int>();
            foreach (CheckBox cb in panelLevel.Controls)
            {
                if (cb.Checked)
                {
                    lst.Add(int.Parse(cb.Text));
                }
            }
            return lst;
        }

        private void OutWarning(string p)
        {
            tsslWarning.Text ="警告："+ p;
        }
        CGoogleImage img;
        // 开始下载
        public void StartDownload()
        {
            if (img == null)
                return;
            img.ProcessInfo += img_ProcessInfo;
            lstLevel.Sort();
            foreach (int level in lstLevel)
            {
                img.SavePicByRect(level, x1, y1, x2, y2);
            }
            //for (int i = 1; i <= 16; i++)
            //{
            //    img.GetPicByRect(i, 113.371386, 30.405576, 113.549035, 30.314833);
            //}
            //img.SavePicByRect(20, 113.371386, 30.405576, 113.549035, 30.314833);
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
