using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        long gigasecond = 1000000000;
        long seconds = gigasecond * 1000;

        return moment.AddMilliseconds(seconds);
    }
}