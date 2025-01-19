namespace NibblePoker.Win32Bindings.WinUser.SendKeys;

public enum EEventTypes {
    /// <summary>
    /// The event is a mouse event. Use the mi structure of the union.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.MOUSEINPUT"/>
    INPUT_MOUSE = 0,

    /// <summary>
    /// The event is a keyboard event. Use the ki structure of the union.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.KEYBDINPUT"/>
    INPUT_KEYBOARD = 1,

    /// <summary>
    /// The event is a hardware event. Use the hi structure of the union.
    /// </summary>
    /// <seealso cref="Structures.InputUnion"/>
    /// <seealso cref="Structures.HARDWAREINPUT"/>
    INPUT_HARDWARE = 2,
}
