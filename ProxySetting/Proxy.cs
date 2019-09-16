using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace ProxySetting
{
    class Proxy
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_PROXY_EXCEPTION_CHANGED = 95;
        public const int INTERNET_OPTION_REFRESH = 37;
        public const string settingkey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        public const string exceptionkey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

        static void setProxy(string proxyhost, string proxyByPass, bool proxyEnabled)
        {

            if (proxyEnabled == true)
            {
                Registry.SetValue(settingkey, "ProxyServer", proxyhost);
            }
            Registry.SetValue(settingkey, "ProxyEnable", proxyEnabled ? 1 : 0);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);

            if (proxyEnabled == true)
            {
                Registry.SetValue(exceptionkey, "ProxyOverride", proxyByPass);
                // Forcing the OS to refresh the IE settings to reflect new proxy settings.
                InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY_EXCEPTION_CHANGED, IntPtr.Zero, 0);
                InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            }
        }

        internal static void setProxy(string proxy, string proxyByPass)
        {
            setProxy(proxy, proxyByPass, true);
        }

        public static void disableProxy()
        {
            setProxy("", "", false);
        }
    }
}
