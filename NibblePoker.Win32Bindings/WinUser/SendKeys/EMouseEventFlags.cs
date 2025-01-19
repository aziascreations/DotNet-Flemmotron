namespace NibblePoker.Win32Bindings.WinUser.SendKeys;

// ReSharper disable InconsistentNaming
[Flags]
public enum EMouseEventFlags : uint {
    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-MOUSEINPUT

    /// <summary>
    /// Movement occurred.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_MOVE = 0x0001,

    /// <summary>
    /// The left button was pressed.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_LEFTDOWN = 0x0002,

    /// <summary>
    /// The left button was released.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_LEFTUP = 0x0004,

    /// <summary>
    /// The right button was pressed.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_RIGHTDOWN = 0x0008,

    /// <summary>
    /// The right button was released.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_RIGHTUP = 0x0010,

    /// <summary>
    /// The middle button was pressed.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_MIDDLEDOWN = 0x0020,

    /// <summary>
    /// The middle button was released.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_MIDDLEUP = 0x0040,

    /// <summary>
    /// An X button was pressed.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_XDOWN = 0x0080,

    /// <summary>
    /// An X button was released.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_XUP = 0x0100,

    /// <summary>
    /// The wheel was moved, if the mouse has a wheel.
    /// The amount of movement is specified in mouseData.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_WHEEL = 0x0800,

    /// <summary>
    /// The wheel was moved horizontally, if the mouse has a wheel.
    /// The amount of movement is specified in mouseData.
    /// </summary>
    /// <remarks>Windows XP/2000: This value is not supported</remarks>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_HWHEEL = 0x1000,

    /// <summary>
    /// The <see href="https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-mousemove">WM_MOUSEMOVE</see>
    ///   messages will not be coalesced.
    /// The default behavior is to coalesce WM_MOUSEMOVE messages.
    /// </summary>
    /// <remarks>Windows XP/2000: This value is not supported</remarks>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,

    /// <summary>
    /// Maps coordinates to the entire desktop.
    /// Must be used with <see cref="MOUSEEVENTF_ABSOLUTE"/>.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_VIRTUALDESK = 0x4000,

    /// <summary>
    /// The dx and dy members contain normalized absolute coordinates.
    /// If the flag is not set, `dx` and `dy` contain relative data (the change in position since the last reported position).
    /// This flag can be set, or not set, regardless of what kind of mouse or other pointing device, if any, is connected to the system.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    MOUSEEVENTF_ABSOLUTE = 0x8000,
}
