using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment) => moment.Add(TimeSpan.FromSeconds(1_000_000_000));
}