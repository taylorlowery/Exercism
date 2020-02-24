using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] proverb = new string[0];

        if (subjects.Length > 0)
        {
            proverb = subjects.Zip(subjects.Skip(1), (a, b) => $"For want of a { a } the { b } was lost.").Append($"And all for the want of a { subjects.First() }.").ToArray();
        }

        return proverb;
    }

    public static string ProverbLine(string thing1, string thing2) => $"For want of a {thing1} the { thing2 } was lost.";
}