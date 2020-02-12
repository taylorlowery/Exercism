using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronym = String.Empty;
        string[] words = phrase.ToUpper().Replace("-", " ").Replace("_", " ").Split(" ");
        foreach (var word in words)
        {
            if (!String.IsNullOrWhiteSpace(word))
            {
                acronym += word[0];
            }
        }

        return acronym;
    }
}