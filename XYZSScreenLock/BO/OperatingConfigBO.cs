using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZSScreenLock.Helper;

namespace XYZSScreenLock.BO
{
    class OperatingConfigBO
    {
        /// <summary>
        /// KEY
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// 是否记录操作
        /// </summary>
        public bool isRecording { get; set; }
        /// <summary>
        /// 启用操作次数
        /// </summary>
        public bool isFrequency { get; set; }

        /// <summary>
        /// 操作次数
        /// </summary>
        public int frequency { get; set; }
        /// <summary>
        /// 是否最后执行程序
        /// </summary>
        public bool isFinalProcedure { get; set; }
        /// <summary>
        /// 最后执行程序
        /// </summary>
        public string finalProcedure { get; set; }


        public OperatingConfigBO()
        {
            this.key = "Operating";
        }
        public static OperatingConfigBO getOperatingConfigBO()
        {
            OperatingConfigBO oBO = new OperatingConfigBO();
            oBO.isRecording = InIHelper.ReadConfig<bool>(oBO.key, "isRecording");
            oBO.isFrequency = InIHelper.ReadConfig<bool>(oBO.key, "isFrequency");
            int frequency = InIHelper.ReadConfig<int>(oBO.key, "frequency");
            oBO.frequency = frequency == 0 ? 1 : frequency;
            oBO.isFinalProcedure = InIHelper.ReadConfig<bool>(oBO.key, "isFinalProcedure");
            string finalProcedure = InIHelper.ReadConfig<string>(oBO.key, "finalProcedure");
            if (finalProcedure != null && finalProcedure != "")
                oBO.finalProcedure = finalProcedure;
            return oBO;
        }
        public static bool setOperatingConfigBO(OperatingConfigBO oBO)
        {
            try
            {
                InIHelper.WriteConfig(oBO.key, "isRecording", oBO.isRecording.ToString());
                InIHelper.WriteConfig(oBO.key, "isFrequency", oBO.isFrequency.ToString());
                InIHelper.WriteConfig(oBO.key, "frequency", oBO.frequency.ToString());
                InIHelper.WriteConfig(oBO.key, "isFinalProcedure", oBO.isFinalProcedure.ToString());
                InIHelper.WriteConfig(oBO.key, "finalProcedure", oBO.finalProcedure);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
