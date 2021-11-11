using System;
using System.Runtime.InteropServices;

namespace helpers.StarCitizen_DevTool
{
    class func
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
        public const uint MOUSEEVENTF_MOVE = 0x0001;
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Int32 vKey);
        public static int VK_LEFT = 0x25;
        public static int VK_UP = 0x26;
        public static int VK_RIGHT = 0x27;
        public static int VK_DOWN = 0x28;
        public static int VK_NUMPAD0 = 0x60;
        public static int VK_NUMPAD1 = 0x61;
        public static int VK_NUMPAD7 = 0x67;
    }
}
