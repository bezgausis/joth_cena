using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace slotmachine
{
     // si klase nodrosina cd rom atveršanu/aizveršanu
    class disk_action
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
        public static bool ProcessCDTray(bool open)
        {
            int ret = 0;
            //do a switch of the value passed
            switch (open)
            {
                case true:
                    ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                    return true;

                case false: ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
                    return true;

                default: ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero); return true;
            }
        }


       

    }
}
