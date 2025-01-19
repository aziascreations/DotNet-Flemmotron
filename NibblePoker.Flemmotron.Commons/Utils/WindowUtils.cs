namespace NibblePoker.Flemmotron.Commons.Utils;

public class WindowUtils {
    /*public static IReadOnlyList<int> FindWindowByClassName(string className)
    {
        var windowList = new List<int>();
        EnumWindows(OnWindowEnum, 0);
        return windowList;

        bool OnWindowEnum(int hwnd, int lparam)
        {
            var lpString = new StringBuilder(512);
            GetClassName(hwnd, lpString, lpString.Capacity);
            if (lpString.ToString().Equals(className, StringComparison.InvariantCultureIgnoreCase))
            {
                windowList.Add(hwnd);
            }

            return true;
        }
    }*/
}
