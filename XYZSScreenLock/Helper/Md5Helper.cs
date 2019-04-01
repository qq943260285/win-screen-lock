using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace XYZSScreenLock.Helper
{
    class Md5Helper
    {
        /// <summary>
        /// 计算MD5
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Md5(string text)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(text))
                return result;
            result = GetMd5Hash(text);
            return result;
        }


        private static string GetMd5Hash(string text)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder sBuilder = new StringBuilder();
                foreach (byte t in data)
                {
                    sBuilder.Append(t.ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
        /// <summary>
        /// 比较字符串和MD5
        /// </summary>
        /// <param name="text"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static bool VerifyMd5Hash(string text, string hash)
        {
            return 0 == StringComparer.OrdinalIgnoreCase.Compare(GetMd5Hash(text), hash);
        }
    }
}
