using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZSScreenLock.Helper
{
    class LogHelper
    {
        public static string Path = Application.StartupPath + "\\AppLog.log";
        public static void addLog(string str)
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff")+"\t"+ str);
            }
        }
    }
}
