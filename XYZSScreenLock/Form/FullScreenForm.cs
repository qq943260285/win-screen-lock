using CCWin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XYZSScreenLock.BO;
using XYZSScreenLock.Helper;
using XYZSScreenLock.Hook;

namespace XYZSScreenLock.Form
{
    public partial class FullScreenForm : Skin_Mac
    {
        public string passMd5 { get; set; }
        private OperatingConfigBO oBO;

        public FullScreenForm()
        {
            InitializeComponent();

        }
        KeysHook hook;
        FullPasswordForm fullPassForm = new FullPasswordForm();
        private void Form1_Load(object sender, EventArgs e)
        {
            hook = new KeysHook();
            this.time1.Parent = this.skinPictureBox1;
            this.skinLabel1.Parent= this.skinPictureBox1;
            //==
            FullScreenConfigBO tmpFBO = FullScreenConfigBO.getFullScreenConfigBO();
            if (tmpFBO.isImg)
            {
                // this.BackPalace = File.Exists(tmpFBO.backgroundImg) ? Image.FromFile(tmpFBO.backgroundImg) : null;
                this.skinPictureBox1.ImageLocation = File.Exists(tmpFBO.backgroundImg) ? tmpFBO.backgroundImg : "";
            }
            else
            {
                this.skinPictureBox1.BackColor = tmpFBO.backgroundColor;
                //this.CaptionBackColorTop = tmpFBO.backgroundColor;
                //this.CaptionBackColorBottom = tmpFBO.backgroundColor;
                //this.BackColor = tmpFBO.backgroundColor;
            }
            this.SkinOpacity = tmpFBO.transparency * 0.01;

            //===
            PasswordConfigBO pBO = PasswordConfigBO.getPasswordConfigBO();
            infoPictureBox.Visible = pBO.isPasswordPrompt;
            infoLabel.Text = pBO.passwordPrompt;

            //===
            this.oBO = OperatingConfigBO.getOperatingConfigBO();

            skinLabel1.Text = "可尝试次数：" + this.oBO.frequency;
            skinLabel1.Visible = this.oBO.isFrequency;


            hook.Hook_Start();
            passTextBox.Text = "";
            this.timer1.Enabled = true;
            FullScreenHelper.SetFormFullScreen(true);
            this.WindowState = FormWindowState.Maximized;
            this.Activate();//


        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (Md5Helper.VerifyMd5Hash(passTextBox.Text, this.passMd5))
            {
                if (this.oBO.isRecording)
                    LogHelper.addLog("开锁成功");
                hook.Hook_Clear();
                this.timer1.Enabled = false;
                FullScreenHelper.SetFormFullScreen(false);
                this.Close();
            }
            else if (this.oBO.frequency > 0)
            {
                if (this.oBO.isRecording)
                    LogHelper.addLog("开锁失败，第" + this.oBO.frequency + "次尝试密码：" + passTextBox.Text);
                if (this.oBO.isFrequency)
                    this.oBO.frequency -= 1;
                skinLabel1.Text = "可尝试次数：" + this.oBO.frequency;
                if (this.oBO.frequency <= 0)
                {
                    if (this.oBO.isFinalProcedure)
                    {
                        Process.Start(this.oBO.finalProcedure);
                    }
                    else
                    {
                        Process.Start("shutdown.exe", "-s");//关机
                    }
                }
            }
            else
            {
                skinPanel2.Visible = false;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {

            infoLabel.Visible = !infoLabel.Visible;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            skinLabel1.Text = "秒后重试" + this.oBO.frequency;
        }

        private void FullScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control && e.Shift)
            {
                e.Handled = true;       //将Handled设置为true，指示已经处理过KeyDown事件 
                //fullPassForm.Visible = false;
                //fullPassForm.ShowDialog();
                fullPassForm.Owner=this;
                fullPassForm.Show();
            }
            if (e.KeyCode == Keys.H && e.Control && e.Shift)
            {
                fullPassForm.Hide();
            }
        }
    }
}



