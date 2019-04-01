namespace XYZSScreenLock.Form
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinWaterTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinWaterTextBox2 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.ConfigImag = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigImag)).BeginInit();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinButton1.Location = new System.Drawing.Point(3, 60);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(154, 23);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "确 定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinWaterTextBox1
            // 
            this.skinWaterTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinWaterTextBox1.Location = new System.Drawing.Point(3, 3);
            this.skinWaterTextBox1.Name = "skinWaterTextBox1";
            this.skinWaterTextBox1.PasswordChar = '*';
            this.skinWaterTextBox1.Size = new System.Drawing.Size(154, 21);
            this.skinWaterTextBox1.TabIndex = 3;
            this.skinWaterTextBox1.WaterColor = System.Drawing.Color.Silver;
            this.skinWaterTextBox1.WaterText = "请输入密码";
            this.skinWaterTextBox1.WordWrap = false;
            // 
            // skinWaterTextBox2
            // 
            this.skinWaterTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinWaterTextBox2.Location = new System.Drawing.Point(3, 29);
            this.skinWaterTextBox2.Name = "skinWaterTextBox2";
            this.skinWaterTextBox2.PasswordChar = '*';
            this.skinWaterTextBox2.Size = new System.Drawing.Size(154, 21);
            this.skinWaterTextBox2.TabIndex = 4;
            this.skinWaterTextBox2.WaterColor = System.Drawing.Color.Silver;
            this.skinWaterTextBox2.WaterText = "请确认密码";
            this.skinWaterTextBox2.WordWrap = false;
            // 
            // skinPanel2
            // 
            this.skinPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinWaterTextBox1);
            this.skinPanel2.Controls.Add(this.skinButton1);
            this.skinPanel2.Controls.Add(this.skinWaterTextBox2);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(40, 36);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(160, 89);
            this.skinPanel2.TabIndex = 4;
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // ConfigImag
            // 
            this.ConfigImag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigImag.BackColor = System.Drawing.Color.Transparent;
            this.ConfigImag.Image = global::XYZSScreenLock.Properties.Resources.设_置;
            this.ConfigImag.Location = new System.Drawing.Point(217, 138);
            this.ConfigImag.Name = "ConfigImag";
            this.ConfigImag.Size = new System.Drawing.Size(18, 18);
            this.ConfigImag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigImag.TabIndex = 8;
            this.ConfigImag.TabStop = false;
            this.skinToolTip1.SetToolTip(this.ConfigImag, "设置");
            this.ConfigImag.Click += new System.EventHandler(this.ConfigImag_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BackShade = false;
            this.BorderColor = System.Drawing.Color.White;
            this.BorderRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CanResize = false;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.CaptionHeight = 25;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(240, 160);
            this.Controls.Add(this.ConfigImag);
            this.Controls.Add(this.skinPanel2);
            this.DropBack = false;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiAutoScroll = false;
            this.MdiBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinimizeBox = false;
            this.MobileApi = false;
            this.Name = "MainForm";
            this.Opacity = 0.1D;
            this.Radius = 8;
            this.ShadowWidth = 3;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Tag = "屏幕锁-小宇专属";
            this.Text = "";
            this.TitleColor = System.Drawing.Color.Gainsboro;
            this.TitleOffset = new System.Drawing.Point(0, 5);
            this.skinToolTip1.SetToolTip(this, "小宇专属-屏幕锁");
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigImag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox1;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox2;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinPictureBox ConfigImag;
    }
}

