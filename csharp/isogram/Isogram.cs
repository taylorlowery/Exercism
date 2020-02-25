using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Dictionary<char, int> charDict = new Dictionary<char, int>();

        foreach (var letter in word.ToLower())
        {
            if (letter != ' '  && letter != '-')
            {
                if (charDict.ContainsKey(letter))
                {
                    return false;
                }
                else
                {
                    charDict[letter] = 1;
                }
            }
            
        }

        return true;
    }
}
