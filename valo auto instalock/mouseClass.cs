using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace valo_auto_instalock
{
    public class mouseClass
    {
        [DllImport("user32.dll")]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        public const int MOUSEEVENTF_LEFTUP = 0x0004;
    }
}
