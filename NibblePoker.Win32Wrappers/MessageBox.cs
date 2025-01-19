using System.ComponentModel;
using System.Runtime.InteropServices;
using static NibblePoker.Win32Bindings.User32;

namespace NibblePoker.Win32Wrappers;

public static class MessageBox {
    // ReSharper disable once EnumUnderlyingTypeIsInt
    public enum EResults : int {
        Error = 0,
        Abort = IDABORT,
        Cancel = IDCANCEL,
        Continue = IDCONTINUE,
        Ignore = IDIGNORE,
        No = IDNO,
        Ok = IDOK,
        Retry = IDRETRY,
        TryAgain = IDTRYAGAIN,
        Yes = IDYES,
    }

    public static EResults Show(string title, string content, uint options = 0) {
        nint ptrTitle = Marshal.StringToHGlobalUni(title);
        nint ptrContent = Marshal.StringToHGlobalUni(content);

        try {
            EResults mbResult = (EResults)MessageBoxW(IntPtr.Zero, ptrContent, ptrTitle, options);

            if(mbResult == EResults.Error) {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            // TODO: Check if the code is known !
            /*else {
#if DEBUG
                Console.WriteLine("Mode=Debug");
#else
    Console.WriteLine("Mode=Release");
#endif
            }*/

            return mbResult;
        } finally {
            Marshal.FreeHGlobal(ptrContent);
            Marshal.FreeHGlobal(ptrTitle);
        }
    }

    /*public static int ShowSafe(string title, string content, uint options = 0) {
        return 0;
    }*/
}
