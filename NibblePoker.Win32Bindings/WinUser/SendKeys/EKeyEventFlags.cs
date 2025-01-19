namespace NibblePoker.Win32Bindings.WinUser.SendKeys;

// ReSharper disable InconsistentNaming
[Flags]
public enum EKeyEventFlags : uint {
    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput

    /// <summary>
    /// If specified, the wScan scan code consists of a sequence of two bytes, where the first byte has a value of 0xE0.
    /// See <see href="https://learn.microsoft.com/en-us/windows/win32/inputdev/about-keyboard-input#extended-key-flag">Extended-Key Flag</see>
    ///  for more info.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.KEYBDINPUT"/>
    KEYEVENTF_EXTENDEDKEY = 0x0001,

    /// <summary>
    /// If specified, the key is being released.
    /// If not specified, the key is being pressed.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.KEYBDINPUT"/>
    KEYEVENTF_KEYUP = 0x0002,

    /// <summary>
    /// If specified, <see cref="Structures.KEYBDINPUT.wScan"/> identifies the key and <see cref="Structures.KEYBDINPUT.wVk"/> is ignored.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.KEYBDINPUT"/>
    KEYEVENTF_SCANCODE = 0x0004,

    /// <summary>
    /// If specified, the system synthesizes a VK_PACKET keystroke.
    /// The <see cref="Structures.KEYBDINPUT.wVk"/> parameter must be zero.
    /// This flag can only be combined with the <see cref="KEYEVENTF_KEYUP"/> flag.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.KEYBDINPUT"/>
    KEYEVENTF_UNICODE = 0x0008,
}
