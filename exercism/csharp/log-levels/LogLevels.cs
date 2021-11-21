using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        var message = logLine.Split(':', StringSplitOptions.TrimEntries)[1];

        return message;
    }

    public static string LogLevel(string logLine)
    {
        var level = logLine.Split(']')[0][1..];

        return level.ToLowerInvariant();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
