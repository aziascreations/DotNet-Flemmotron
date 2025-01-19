using System.Runtime.InteropServices;

namespace NibblePoker.Win32Bindings.WinUser.SendKeys;

public class Imports {
    [DllImport("user32.dll", CallingConvention = CallingConvention.Winapi)]
    public static extern uint SendInput(uint nInputs, Structures.INPUT[] pInputs, int cbSize);
}
