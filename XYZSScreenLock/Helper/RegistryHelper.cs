using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZSScreenLock.Helper
{
    class RegistryHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        public static bool ManageTaskManager(bool isOpen)
        {
            try
            {
                RegistryKey currentUser = Registry.CurrentUser;
                RegistryKey system = currentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                //如果system项不存在就创建这个项
                if (system == null)
                {
                    system = currentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                }
                system.SetValue("DisableTaskmgr", isOpen ? 0 : 1, RegistryValueKind.DWord);
                currentUser.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
