using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string searchString)
    {
        return str[(str.IndexOf(searchString) + searchString.Length)..];
    }

    public static string SubstringBetween(this string str, string searchStringStart, string searchStringEnd)
    {
        return str[(str.IndexOf(searchStringStart) + searchStringStart.Length)..str.IndexOf(searchStringEnd)];
    }

    public static string Message(this string str)
    {
        return str.Split(':', StringSplitOptions.TrimEntries)[1];
    }

    public static string LogLevel(this string str)
    {
        return str.Split(']')[0][1..];
    }
}
