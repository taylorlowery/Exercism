using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength < 1)
        {
            throw new ArgumentException("Slice length must be greater than 0");
        }
        if(sliceLength > numbers.Length)
        {
            throw new ArgumentException("Slice length is too long");
        }
        if(numbers.Length == 0)
        {
            throw new ArgumentException("Empty series is invald");
        }
        
        List<string> series = new List<string>();

        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            series.Add(numbers.Substring(i, sliceLength));
        }
        
        return series.ToArray();
    }
}