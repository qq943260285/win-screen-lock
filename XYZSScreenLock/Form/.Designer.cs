namespace XYZSScreenLock.Form
{
    partial class FullScreenForm
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
            this.passTextBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.infoLabel = new CCWin.SkinControl.SkinLabel();
            this.infoPictureBox = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.time1 = new XYZSScreenLock.Component.Time();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
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
            // passTextBox
            // 
            this.passTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passTextBox.Location = new System.Drawing.Point(3, 3);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(154, 21);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.WaterColor = System.Drawing.Color.Silver;
            this.passTextBox.WaterText = "请输入密码";
            this.passTextBox.WordWrap = false;
            // 
            // skinPanel2
            // 
            this.skinPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.passTextBox);
            this.skinPanel2.Controls.Add(this.skinButton1);
            this.skinPanel2.Controls.Add(this.infoLabel);
            this.skinPanel2.Controls.Add(this.infoPictureBox);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(130, 96);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel2.Size = new System.Drawing.Size(160, 89);
            this.skinPanel2.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.BorderColor = System.Drawing.Color.White;
            this.infoLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.infoLabel.Location = new System.Drawing.Point(29, 31);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(80, 17);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "密码提示信息";
            this.infoLabel.Visible = false;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.infoPictureBox.Image = global::XYZSScreenLock.Properties.Resources.关于;
            this.infoPictureBox.Location = new System.Drawing.Point(8, 32);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(15, 15);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPictureBox.TabIndex = 9;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Red;
            this.skinLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.skinLabel1.Location = new System.Drawing.Point(7, 259);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(79, 21);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "可尝试次数：";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skinLabel1.UseCompatibleTextRendering = true;
            this.skinLabel1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(422, 282);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 6;
            this.skinPictureBox1.TabStop = false;
            // 
            // time1
            // 
            this.time1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.time1.Location = new System.Drawing.Point(162, 56);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(121, 34);
            this.time1.TabIndex = 11;
            // 
            // FullScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.BorderRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CanResize = false;
            this.CaptionBackColorBottom = System.Drawing.Color.Transparent;
            this.CaptionBackColorTop = System.Drawing.Color.Transparent;
            this.CaptionHeight = 4;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.ControlBox = false;
            this.Controls.Add(this.time1);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinPictureBox1);
            this.DropBack = false;
            this.EffectWidth = 0;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InnerBorderColor = System.Drawing.Color.Transparent;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MdiAutoScroll = false;
            this.MdiBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinimizeBox = false;
            this.Mobile = CCWin.MobileStyle.None;
            this.MobileApi = false;
            this.Name = "FullScreenForm";
            this.Opacity = 0D;
            this.Radius = 0;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.Shadow = false;
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Tag = "屏幕锁-小宇专属";
            this.Text = "";
            this.TitleOffset = new System.Drawing.Point(0, 5);
            this.skinToolTip1.SetToolTip(this, "小宇专属-屏幕锁");
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FullScreenForm_KeyDown);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinWaterTextBox passTextBox;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinPictureBox infoPictureBox;
        private CCWin.SkinControl.SkinLabel infoLabel;
        private System.Windows.Forms.Timer timer2;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private Component.Time time1;
    }
}

