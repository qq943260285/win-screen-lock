using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZSScreenLock.Component
{
    public partial class Time : UserControl
    {
        public Time()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            skinLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
    }
}
