using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string allCharString = "abcdefghijklmnopqrstuvwxyz";

        foreach (var character in allCharString)
        {
            if (!(input.ToLower().Contains(character)))
            {
                return false;
            }
        }

        return true;
    }
}
