using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> proverb = new List<string>();

        if (subjects.Length > 0)
        {
            for (int i = 0; i < subjects.Length - 1; i++)
            {
                proverb.Add(ProverbLine(subjects[i], subjects[i + 1]));
            }

            proverb.Add($"And all for the want of a {subjects.First()}.");
        }


        return proverb.ToArray();
    }



    public static string ProverbLine(string thing1, string thing2) => $"For want of a {thing1} the { thing2 } was lost.";
}