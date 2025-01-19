namespace NibblePoker.Flemmotron.Commons.Utils;

public class ProcessUtils {
    public static IntPtr GetProcess() {
        return IntPtr.Zero;
    }
    
    /*[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnumWindows(EnumedWindow lpEnumFunc, ArrayList lParam);

    public static ArrayList GetWindows()
    {    
        ArrayList windowHandles = new ArrayList();
        EnumedWindow callBackPtr = GetWindowHandle;
        EnumWindows(callBackPtr, windowHandles);

        return windowHandles;    
    }

    private static bool GetWindowHandle(IntPtr windowHandle, ArrayList windowHandles)
    {
        windowHandles.Add(windowHandle);
        return true;
    }*/

}
