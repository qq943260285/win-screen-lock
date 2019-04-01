﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZSScreenLock.Helper
{
    class FullScreenHelper
    {
        /// <summary>  
        /// 设置全屏或这取消全屏  
        /// </summary>  
        /// <param name="fullscreen">true:全屏 false:恢复</param>  
        /// <param name="rectOld">设置的时候，此参数返回原始尺寸，恢复时用此参数设置恢复</param>  
        /// <returns>设置结果</returns>  
        public static Boolean SetFormFullScreen(Boolean fullscreen)//, ref Rectangle rectOld
        {
            Rectangle rectOld = Rectangle.Empty;
            Int32 hwnd = 0;
            hwnd = FindWindow("Shell_TrayWnd", null);//获取任务栏的句柄

            if (hwnd == 0) return false;

            if (fullscreen)//全屏
            {
                ShowWindow(hwnd, SW_HIDE);//隐藏任务栏
                RegistryHelper.ManageTaskManager(false);
                SystemParametersInfo(SPI_GETWORKAREA, 0, ref rectOld, SPIF_UPDATEINIFILE);//get屏幕范围
                Rectangle rectFull = Screen.PrimaryScreen.Bounds;//全屏范围
                SystemParametersInfo(SPI_SETWORKAREA, 0, ref rectFull, SPIF_UPDATEINIFILE);//窗体全屏幕显示
            }
            else//还原 
            {
                ShowWindow(hwnd, SW_SHOW);//显示任务栏
                RegistryHelper.ManageTaskManager(true);
                SystemParametersInfo(SPI_SETWORKAREA, 0, ref rectOld, SPIF_UPDATEINIFILE);//窗体还原
            }
            return true;
        }

        #region user32.dll

        public const Int32 SPIF_UPDATEINIFILE = 0x1;
        public const Int32 SPI_SETWORKAREA = 47;
        public const Int32 SPI_GETWORKAREA = 48;
        public const Int32 SW_SHOW = 5;
        public const Int32 SW_HIDE = 0;

        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        public static extern Int32 ShowWindow(Int32 hwnd, Int32 nCmdShow);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern Int32 FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        private static extern Int32 SystemParametersInfo(Int32 uAction, Int32 uParam, ref Rectangle lpvParam, Int32 fuWinIni);

        #endregion

    }
}
