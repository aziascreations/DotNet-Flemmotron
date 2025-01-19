namespace NibblePoker.Win32Bindings.WinUser.SendKeys;

// ReSharper disable InconsistentNaming
[Flags]
public enum EKeyEventFlags : uint {
    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput
    KEYEVENTF_EXTENDEDKEY = 0x0001,
    KEYEVENTF_KEYUP = 0x0002,
    KEYEVENTF_SCANCODE = 0x0004,
    KEYEVENTF_UNICODE = 0x0008,
}
