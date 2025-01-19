using System.Runtime.InteropServices;

namespace NibblePoker.Win32Bindings;

// ReSharper disable UnusedMember.Global
public static class Kernel32 {
    
    /// https://learn.microsoft.com/en-us/windows/win32/api/utilapiset/nf-utilapiset-beep
    /// <remarks>
    /// After some testing on a Windows 11 23H2 machine, it appears that the frequency limits are not enforced.
    /// </remarks>
    [DllImport("kernel32.dll", CharSet = CharSet.None, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool Beep([In] uint dwFreq, [In] uint dwDuration);
    
}
