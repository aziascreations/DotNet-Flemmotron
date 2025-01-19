using System.Runtime.InteropServices;

namespace NibblePoker.Win32Bindings;

public class WinDef {
    
    /// https://learn.microsoft.com/en-us/windows/win32/api/windef/ns-windef-point
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT {
        public UInt32 x; // LONG
        public UInt32 y; // LONG
    }
    
    /// https://learn.microsoft.com/en-us/windows/win32/api/windef/ns-windef-rect
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT {
        public UInt32 left; // LONG
        public UInt32 top; // LONG
        public UInt32 right; // LONG
        public UInt32 bottom; // LONG
    }
    
}
