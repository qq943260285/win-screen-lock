using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZSScreenLock.Helper;

namespace XYZSScreenLock.BO
{
    class PasswordConfigBO
    {

        /// <summary>
        /// KEY
        /// </summary>
        public String key { get; set; }
        /// <summary>
        /// 是否启用默认密码
        /// </summary>
        public bool isDefaultPassword { get; set; }
        /// <summary>
        /// 默认密码
        /// </summary>
        public string defaultPassword { get; set; }
        /// <summary>
        /// 是否启用密码提示
        /// </summary>
        public bool isPasswordPrompt { get; set; }
        /// <summary>
        /// 密码提示
        /// </summary>
        public string passwordPrompt { get; set; }
        /// <summary>
        /// 直接进入锁屏
        /// </summary>
        public bool enterDirectly { get; set; }
        public PasswordConfigBO()
        {
            this.key = "Password";
            this.isDefaultPassword = false;
            this.isPasswordPrompt = false;
            this.enterDirectly = false;
        }
        public static PasswordConfigBO getPasswordConfigBO()
        {
            PasswordConfigBO tmp = new PasswordConfigBO();
            tmp.isDefaultPassword = InIHelper.ReadConfig<bool>(tmp.key, "isDefaultPassword");
            string defaultPassword = InIHelper.ReadConfig<string>(tmp.key, "defaultPassword");
            if (defaultPassword != null && defaultPassword != "")
                tmp.defaultPassword = DesHelper.Decode(defaultPassword);
            tmp.isPasswordPrompt = InIHelper.ReadConfig<bool>(tmp.key, "isPasswordPrompt");
            string passwordPrompt = InIHelper.ReadConfig<string>(tmp.key, "passwordPrompt");
            if (passwordPrompt != null && passwordPrompt != "")
                tmp.passwordPrompt = passwordPrompt;
            tmp.enterDirectly = InIHelper.ReadConfig<bool>(tmp.key, "enterDirectly");
            return tmp;
        }
        public static bool setPasswordConfigBO(PasswordConfigBO pBO)
        {
            try
            {
                InIHelper.WriteConfig(pBO.key, "isDefaultPassword", pBO.isDefaultPassword.ToString());
                InIHelper.WriteConfig(pBO.key, "isPasswordPrompt", pBO.isPasswordPrompt.ToString());
                InIHelper.WriteConfig(pBO.key, "passwordPrompt", pBO.passwordPrompt);
                InIHelper.WriteConfig(pBO.key, "enterDirectly", pBO.enterDirectly.ToString());
                InIHelper.WriteConfig(pBO.key, "defaultPassword", DesHelper.Encode(pBO.defaultPassword));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
