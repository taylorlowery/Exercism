using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class RotationalCipher
{
    public static Regex regex = new Regex(@"[a-zA-Z]");

    public static string Rotate(string text, int shiftKey)
    {
        return new string(text.ToCharArray().Select(c => RotateChar(c, shiftKey)).ToArray());
    }

    public static Char RotateChar(char letter, int shift)
    {
        if (regex.IsMatch(letter.ToString())) {
            char newChar = (char)(letter + shift);

            if ((letter <= 91 && 91 <= newChar) || (97 <= letter && 123 <= newChar))
            {
                newChar -= (char)26;
            }

            return newChar;
        }

        return letter;        
    }
}