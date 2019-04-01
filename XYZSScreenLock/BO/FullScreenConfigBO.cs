using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZSScreenLock.Helper;

namespace XYZSScreenLock.BO
{
    class FullScreenConfigBO
    {
        /// <summary>
        /// KEY
        /// </summary>
        public String key { get; set; }
        /// <summary>
        /// 是否图像
        /// </summary>
        public bool isImg { get; set; }
        /// <summary>
        /// 背景颜色
        /// </summary>
        public Color backgroundColor { get; set; }
        /// <summary>
        /// 背景图片地址
        /// </summary>
        public String backgroundImg { get; set; }
        /// <summary>
        /// 透明度
        /// </summary>
        public int transparency { get; set; }
        /// <summary>
        /// 关闭任务管理器
        /// </summary>
        public bool offTaskManager { get; set; }
        public FullScreenConfigBO()
        {
            this.key = "FullScreen";
            this.isImg = false;
            this.backgroundImg = "";
            this.backgroundColor = Color.White;
            this.offTaskManager = true;
            this.transparency = 100;
        }
        public static FullScreenConfigBO getFullScreenConfigBO()
        {
            FullScreenConfigBO fBO = new FullScreenConfigBO();
            bool isImg = InIHelper.ReadConfig<bool>(fBO.key, "isImg");
            fBO.isImg = isImg;
            string backgroundColor = InIHelper.ReadConfig<string>(fBO.key, "backgroundColor");
            if (backgroundColor != null && backgroundColor != "")
                fBO.backgroundColor = ColorTranslator.FromHtml(backgroundColor);
            string backgroundImg = InIHelper.ReadConfig<string>(fBO.key, "backgroundImg");
            if (File.Exists(backgroundImg))
            {
                fBO.backgroundImg = backgroundImg;
            }
            string transparency = InIHelper.ReadConfig<string>(fBO.key, "transparency");
            if (transparency != null && transparency != "")
                fBO.transparency = Int32.Parse(transparency);
            fBO.offTaskManager = InIHelper.ReadConfig<bool>(fBO.key, "offTaskManager");
            return fBO;
        }
        public static bool setFullScreenConfigBO(FullScreenConfigBO fBO)
        {
            try
            {
                InIHelper.WriteConfig(fBO.key, "isImg", fBO.isImg.ToString());
                InIHelper.WriteConfig(fBO.key, "backgroundColor", ColorTranslator.ToHtml(fBO.backgroundColor));
                InIHelper.WriteConfig(fBO.key, "backgroundImg", fBO.backgroundImg);
                InIHelper.WriteConfig(fBO.key, "transparency", fBO.transparency.ToString());
                InIHelper.WriteConfig(fBO.key, "offTaskManager", fBO.offTaskManager.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
