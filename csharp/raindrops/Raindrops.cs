using System;
using System.Collections.Generic;

public static class Raindrops
{
    private static readonly IEnumerable<(int divisor, string rainSound)> _divisors = new List<(int divisor, string rainSound)>
    {
        (divisor: 3, rainSound: "Pling"),
        (divisor: 5, rainSound: "Plang"),
        (divisor: 7, rainSound: "Plong"),
    };

    public static string Convert(int number)
    {
        string rainSounds = String.Empty;

        foreach (var divisor in _divisors)
        {
            if (number % divisor.divisor == 0)
            {
                rainSounds += divisor.rainSound;
            }
        }

        if (String.IsNullOrWhiteSpace(rainSounds))
        {
            rainSounds = number.ToString();
        }

        return rainSounds;
    }
}