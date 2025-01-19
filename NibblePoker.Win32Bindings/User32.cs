using System.Runtime.InteropServices;

namespace NibblePoker.Win32Bindings;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
public class User32 {
    
    #region MB_* flags

    public const uint MB_ABORTRETRYIGNORE = 0x00000002;
    public const uint MB_CANCELTRYCONTINUE = 0x00000006;
    public const uint MB_HELP = 0x00004000;
    public const uint MB_OK = 0x00000000;
    public const uint MB_OKCANCEL = 0x00000001;
    public const uint MB_RETRYCANCEL = 0x00000005;
    public const uint MB_YESNO = 0x00000004;
    public const uint MB_YESNOCANCEL = 0x00000003;
    
    public const uint MB_ICONEXCLAMATION = 0x00000030;
    public const uint MB_ICONWARNING = 0x00000030;
    public const uint MB_ICONINFORMATION = 0x00000040;
    public const uint MB_ICONASTERISK = 0x00000040;
    public const uint MB_ICONQUESTION = 0x00000020;
    public const uint MB_ICONSTOP = 0x00000010;
    public const uint MB_ICONERROR = 0x00000010;
    public const uint MB_ICONHAND = 0x00000010;
    
    public const uint MB_DEFBUTTON1 = 0x00000000;
    public const uint MB_DEFBUTTON2 = 0x00000100;
    public const uint MB_DEFBUTTON3 = 0x00000200;
    public const uint MB_DEFBUTTON4 = 0x00000300;
    
    public const uint MB_APPLMODAL = 0x00000000;
    public const uint MB_SYSTEMMODAL = 0x00001000;
    public const uint MB_TASKMODAL = 0x00002000;
    
    public const uint MB_DEFAULT_DESKTOP_ONLY = 0x00020000;
    public const uint MB_RIGHT = 0x00080000;
    public const uint MB_RTLREADING = 0x00100000;
    public const uint MB_SETFOREGROUND = 0x00010000;
    public const uint MB_TOPMOST = 0x00040000;
    public const uint MB_SERVICE_NOTIFICATION = 0x00200000;
    
    /// <summary>
    /// Used by <see cref="MessageBeep"/> for the sound type that is propagated to <see cref="Kernel32.Beep"/> internally.
    /// </summary>
    public const uint MB_FALLBACK = 0xFFFFFFFF;

    #endregion


    #region MessageBox Returns

    public const int IDABORT = 3;
    public const int IDCANCEL = 2;
    public const int IDCONTINUE = 11;
    public const int IDIGNORE = 5;
    public const int IDNO = 7;
    public const int IDOK = 1;
    public const int IDRETRY = 4;
    public const int IDTRYAGAIN = 10;
    public const int IDYES = 6;

    #endregion
    
    /// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messagebeep
    [DllImport("user32.dll", CharSet = CharSet.None, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool MessageBeep(uint uType);
    
    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.I4)]
    public static extern int MessageBoxA(IntPtr hWnd, nint lpText, nint lpCaption, uint uType);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.I4)]
    public static extern int MessageBoxW(IntPtr hWnd, nint lpText, nint lpCaption, uint uType);
    
    //[DllImport("user32.dll")]
    //public static extern int GetClassName(int hWnd, StringBuilder lpString, int nMaxCount);

    //[DllImport("user32")]
    //public static extern int GetWindowText(int hwnd, StringBuilder lptrString, int nMaxCount);
    
}
