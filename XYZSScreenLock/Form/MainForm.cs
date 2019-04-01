using CCWin;
using System;
using XYZSScreenLock.BO;
using XYZSScreenLock.Helper;

namespace XYZSScreenLock.Form
{
    public partial class MainForm : Skin_Mac
    {

        public MainForm()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordConfigBO pBO = PasswordConfigBO.getPasswordConfigBO();
            if (pBO.isDefaultPassword)
            {
                skinWaterTextBox1.Text = pBO.defaultPassword;
                if (pBO.enterDirectly)
                {
                    skinWaterTextBox2.Text = pBO.defaultPassword;
                    skinButton1_Click(sender, e);
                }
            }
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (skinWaterTextBox1.Text.Length == 0)
            {
                MessageBoxEx.Show("请输入密码");
                return;
            }
            if (skinWaterTextBox1.Text != skinWaterTextBox2.Text)
            {
                MessageBoxEx.Show("两次密码不一致");
                return;
            }
            this.Visible = false;
            FullScreenForm configForm = new FullScreenForm();
            configForm.passMd5 = Md5Helper.Md5(skinWaterTextBox2.Text);
            configForm.ShowDialog();
            this.Visible = true;
        }

        private void ConfigImag_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
        }
    }
}



