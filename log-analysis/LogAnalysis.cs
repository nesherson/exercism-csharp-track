using System;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static string SubstringAfter(this string str, string separator)
    {
        return str.Split(separator)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string SubstringBetween(this string str, string start, string end)
    {
        int startIndex = str.IndexOf(start) + start.Length;
        int length = str.IndexOf(end) - startIndex;

        return str.Substring(startIndex, length);
    }

    // TODO: define the 'Message()' extension method on the `string` type

    public static string Message(this string str)
    {
        return str.SubstringAfter(":").Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type


}