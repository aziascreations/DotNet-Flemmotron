using System.ComponentModel;
using System.Runtime.InteropServices;
using NibblePoker.Win32Bindings;

namespace NibblePoker.Win32Wrappers;

// ReSharper disable MemberCanBePrivate.Global
public static class Beeps {
    public enum SoundTypes : uint {
        Fallback = User32.MB_FALLBACK,
        CriticalStop = User32.MB_ICONERROR,
        Asterisk = User32.MB_ICONINFORMATION,
        Question = User32.MB_ICONQUESTION, // Doesn't work on W11 !!
        Exclamation = User32.MB_ICONWARNING,
        Default = User32.MB_OK,
    }

    public static void Beep(uint frequency, uint durationMs) {
        if(!Kernel32.Beep(frequency, durationMs)) {
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }

    public static void Beep(uint type) {
        if(!User32.MessageBeep(type)) {
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }

    public static void Beep(SoundTypes type) {
        Beep((uint)type);
    }

    public static bool BeepSafe(uint frequency, uint durationMs) {
        return Kernel32.Beep(frequency, durationMs);
    }

    public static bool BeepSafe(uint type) {
        return User32.MessageBeep(type);
    }

    public static bool BeepSafe(SoundTypes type) {
        return BeepSafe((uint)type);
    }
}
