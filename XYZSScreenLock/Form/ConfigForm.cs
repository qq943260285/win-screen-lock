using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZSScreenLock.BO;
using XYZSScreenLock.Helper;

namespace XYZSScreenLock.Form
{
    public partial class ConfigForm : Skin_Mac
    {

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            FullScreenConfigLoad();
            PasswordConfigBOLoad();
            OperatingConfigBOLoad();


        }
        private void PasswordConfigBOLoad()
        {
            PasswordConfigBO pBO = PasswordConfigBO.getPasswordConfigBO();
            skinCheckBox2.Checked = pBO.isDefaultPassword;
            skinWaterTextBox1.Text = pBO.defaultPassword;
            skinCheckBox3.Checked = pBO.isPasswordPrompt;
            skinWaterTextBox3.Text = pBO.passwordPrompt;
            skinCheckBox6.Checked = pBO.enterDirectly;
        }
        private void PasswordConfigBOSave()
        {
            PasswordConfigBO pBO = new PasswordConfigBO();
            pBO.isDefaultPassword = skinCheckBox2.Checked;
            pBO.defaultPassword = skinWaterTextBox1.Text;
            pBO.isPasswordPrompt = skinCheckBox3.Checked;
            pBO.passwordPrompt = skinWaterTextBox3.Text;
            pBO.enterDirectly = skinCheckBox6.Checked;
            PasswordConfigBO.setPasswordConfigBO(pBO);
        }
        private void FullScreenConfigLoad()
        {
            FullScreenConfigBO tmpFBO = FullScreenConfigBO.getFullScreenConfigBO();
            bool isImg = tmpFBO.isImg;
            this.skinRadioButton2.Checked = isImg;
            skinColorSelectPanel1.Visible = !isImg;
            if (isImg)
            {
                if (File.Exists(tmpFBO.backgroundImg))
                    this.skinPictureBox1.ImageLocation = tmpFBO.backgroundImg;
                else
                    this.skinPictureBox1.Image = Properties.Resources.选择图片2__1_;
            }
            else
            {
                this.skinColorSelectPanel1.SelectedColor = tmpFBO.backgroundColor;
                this.skinPictureBox1.BackColor = tmpFBO.backgroundColor;
            }
            this.skinTrackBar1.Value = 100 - tmpFBO.transparency;
            this.skinLabel14.Text = tmpFBO.transparency.ToString();
            this.skinCheckBox1.Checked = tmpFBO.offTaskManager;
        }
        private void FullScreenConfigSave()
        {
            FullScreenConfigBO fBO = new FullScreenConfigBO();
            fBO.isImg = skinRadioButton2.Checked;
            fBO.backgroundImg = skinPictureBox1.ImageLocation;
            fBO.backgroundColor = skinColorSelectPanel1.SelectedColor;
            fBO.transparency = 100 - skinTrackBar1.Value;
            fBO.offTaskManager = skinCheckBox1.Checked;
            FullScreenConfigBO.setFullScreenConfigBO(fBO);
        }
        private void OperatingConfigBOLoad()
        {
            OperatingConfigBO tmp = OperatingConfigBO.getOperatingConfigBO();
            skinCheckBox5.Checked = tmp.isRecording;
            skinCheckBox4.Checked = tmp.isFrequency;
            numericUpDown1.Value = tmp.frequency;
            skinCheckBox7.Checked = tmp.isFinalProcedure;
            skinWaterTextBox2.Text = File.Exists(tmp.finalProcedure) ? tmp.finalProcedure : "";
        }
        private void OperatingConfigBOSave()
        {
            OperatingConfigBO tmp = new OperatingConfigBO();
            tmp.isRecording = skinCheckBox5.Checked;
            tmp.isFrequency = skinCheckBox4.Checked;
            tmp.frequency = Int32.Parse(numericUpDown1.Value.ToString());
            tmp.isFinalProcedure = skinCheckBox7.Checked;
            tmp.finalProcedure = skinWaterTextBox2.Text;
            OperatingConfigBO.setOperatingConfigBO(tmp);
        }

        private void skinColorSelectPanel1_SelectedColorChanged(object sender, EventArgs e)
        {
            skinPictureBox1.BackColor = skinColorSelectPanel1.SelectedColor;

        }

        private void skinRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool b = skinRadioButton2.Checked;
            skinColorSelectPanel1.Visible = !b;
            skinPictureBox1.BackColor = b ? Color.White : skinPictureBox1.BackColor;
            skinPictureBox1.Image = b ? Properties.Resources.选择图片2__1_ : null;
        }

        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool b = skinRadioButton1.Checked;
            skinColorSelectPanel1.Visible = b;
            skinPictureBox1.Image = b ? null : Properties.Resources.选择图片2__1_;
            skinPictureBox1.BackColor = skinColorSelectPanel1.SelectedColor;
        }


        private void skinPictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "全屏背景图 (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                skinPictureBox1.ImageLocation = fileDialog.FileName;
            }
            else
            {
                skinPictureBox1.ImageLocation = "";
                skinPictureBox1.Image = Properties.Resources.选择图片2__1_;
            }

        }

        private void skinTrackBar1_Scroll(object sender, EventArgs e)
        {
            skinLabel14.Text = (100 - skinTrackBar1.Value).ToString();
        }

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FullScreenConfigSave();
            PasswordConfigBOSave();
            OperatingConfigBOSave();
        }

        private void skinCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void skinCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (skinCheckBox6.Checked && !(skinCheckBox2.Checked && skinWaterTextBox1.Text.Length > 0))
            {
                MessageBoxEx.Show("需要启用并设置默认密码");
                skinCheckBox6.Checked = false;
            }
        }

        private void skinWaterTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = Int32.Parse(numericUpDown1.Value.ToString());
        }

        private void skinWaterTextBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "可执行程序 (bat,cmd,exe)|*.bat;*.cmd;*.exe";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                skinWaterTextBox2.Text = fileDialog.FileName;
            }
            else
            {
                skinWaterTextBox2.Text = "";
            }
        }

        private void skinPictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://qq943260285.github.io");
        }

        private void skinPictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://qq943260285.github.io");
        }
    }
}
