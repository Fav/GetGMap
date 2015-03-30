namespace GetGMap
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPathDir = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslWarning = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 276);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(577, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(623, 233);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 69);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始下载";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择图片存放目录";
            // 
            // tbPathDir
            // 
            this.tbPathDir.Location = new System.Drawing.Point(137, 21);
            this.tbPathDir.Name = "tbPathDir";
            this.tbPathDir.Size = new System.Drawing.Size(508, 21);
            this.tbPathDir.TabIndex = 4;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(663, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(35, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "...";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "选择要下载的等级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "说明";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(491, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "(等级越高图片越大，越清晰，由于系统图像尺寸限制，下载的图片不会超过12800*12800的)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelLevel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(32, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 119);
            this.panel1.TabIndex = 6;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Checked = true;
            this.checkBox20.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox20.Location = new System.Drawing.Point(443, 30);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(36, 16);
            this.checkBox20.TabIndex = 20;
            this.checkBox20.Text = "20";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(443, 8);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(36, 16);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(395, 30);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(36, 16);
            this.checkBox19.TabIndex = 19;
            this.checkBox19.Text = "19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(395, 8);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(30, 16);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(345, 30);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(36, 16);
            this.checkBox18.TabIndex = 18;
            this.checkBox18.Text = "18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(345, 8);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(30, 16);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(297, 30);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(36, 16);
            this.checkBox17.TabIndex = 17;
            this.checkBox17.Text = "17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(297, 8);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 16);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(249, 30);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(36, 16);
            this.checkBox16.TabIndex = 16;
            this.checkBox16.Text = "16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(249, 8);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 16);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(201, 30);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(36, 16);
            this.checkBox15.TabIndex = 15;
            this.checkBox15.Text = "15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(202, 8);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 16);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(151, 30);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(36, 16);
            this.checkBox14.TabIndex = 14;
            this.checkBox14.Text = "14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(151, 8);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 16);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(103, 30);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(36, 16);
            this.checkBox13.TabIndex = 13;
            this.checkBox13.Text = "13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(103, 8);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 16);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(55, 30);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(36, 16);
            this.checkBox12.TabIndex = 12;
            this.checkBox12.Text = "12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(55, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 16);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(7, 30);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(36, 16);
            this.checkBox11.TabIndex = 11;
            this.checkBox11.Text = "11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "左上角经纬度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "右下角经纬度";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(508, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(508, 21);
            this.textBox3.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWarning});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslWarning
            // 
            this.tsslWarning.Name = "tsslWarning";
            this.tsslWarning.Size = new System.Drawing.Size(0, 17);
            // 
            // panelLevel
            // 
            this.panelLevel.Controls.Add(this.checkBox20);
            this.panelLevel.Controls.Add(this.checkBox10);
            this.panelLevel.Controls.Add(this.checkBox1);
            this.panelLevel.Controls.Add(this.checkBox19);
            this.panelLevel.Controls.Add(this.checkBox11);
            this.panelLevel.Controls.Add(this.checkBox9);
            this.panelLevel.Controls.Add(this.checkBox2);
            this.panelLevel.Controls.Add(this.checkBox18);
            this.panelLevel.Controls.Add(this.checkBox12);
            this.panelLevel.Controls.Add(this.checkBox8);
            this.panelLevel.Controls.Add(this.checkBox3);
            this.panelLevel.Controls.Add(this.checkBox17);
            this.panelLevel.Controls.Add(this.checkBox13);
            this.panelLevel.Controls.Add(this.checkBox7);
            this.panelLevel.Controls.Add(this.checkBox4);
            this.panelLevel.Controls.Add(this.checkBox16);
            this.panelLevel.Controls.Add(this.checkBox14);
            this.panelLevel.Controls.Add(this.checkBox6);
            this.panelLevel.Controls.Add(this.checkBox5);
            this.panelLevel.Controls.Add(this.checkBox15);
            this.panelLevel.Location = new System.Drawing.Point(89, 32);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(498, 50);
            this.panelLevel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 358);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.tbPathDir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "谷歌影像下载器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelLevel.ResumeLayout(false);
            this.panelLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPathDir;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslWarning;
        private System.Windows.Forms.Panel panelLevel;
    }
}

