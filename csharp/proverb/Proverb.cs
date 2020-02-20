using System;
using System.Collections;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> proverb = new List<string>();

        for (int i = 0; i < subjects.Length - 1; i++)
        {
            proverb.Add(ProverbLine(subjects[i], subjects[i + 1]));
        }

        proverb.Add($"And all for the want of a {subjects[0]}.");

        return proverb.ToArray();
    }



    public static string ProverbLine(string thing1, string thing2) => $"For want of a {thing1} the { thing2 } was lost.";
}