using System;
using System.Collections.Generic;

static class LogLine
{
    public static string Message(string logLine)
    {
        var splitString = new List<string>(logLine.Split());
        splitString.RemoveAt(0);

        return String.Join(" ", splitString.ToArray()).Trim();
    }

    public static string LogLevel(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
