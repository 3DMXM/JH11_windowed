using System;
using System.ComponentModel;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace JH11_windowed
{
    [BepInPlugin("aoe.top.plugins.JH11_windowed", "江湖十一 窗口化", "1.0.0.0")]

    public class JH11_windowed: BaseUnityPlugin
    {
        public static ConfigEntry<windowEnum> windows_size;
        public static ConfigEntry<bool> isWindowed;

        void Awake()
        {
            windows_size = Config.Bind("窗口化设置", "窗口大小", windowEnum._1600x900, new ConfigDescription("", null, new windowEnum()));
        }

        void Update()
        {
            setGameSize(windows_size.Value);
        }

        private void setGameWindowed(bool isWindowed)
        {
            Screen.fullScreen = !isWindowed;

            Logger.LogMessage($"设置窗口化状态为:{isWindowed}");
        }

        private void setGameSize(int width, int height)
        {
            Screen.SetResolution(width, height, false);

            //Logger.LogMessage($"设置窗口大小为:{width} x {height}");
        }

        private void setGameSize(windowEnum site)
        {
            //string size_s = site.ToString();
            string[] size_arr = site.ToString().Split('x');
            // 移除前面的 _ 符号
            int width = int.Parse(size_arr[0].Replace("_", string.Empty).Trim());
            int height = int.Parse(size_arr[1].Replace("_", string.Empty).Trim());
            setGameSize(width, height);
        }


        public enum windowEnum
        {
            _800x600,
            _1024x768,
            _1280x720,
            _1280x800,
            _1280x960,
            _1280x1024,
            _1360x768,
            _1366x768,
            _1440x900,
            _1600x900,
            _1600x1200,
            _1680x1050,
            _1920x1080,
            _1920x1200,
            _2560x1440,
            _2560x1600,
            _3840x2160,
            _3840x2400,
            _4096x2160,
            _4096x2304,

        }

    }
}