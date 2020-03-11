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

            if ((letter <= 'z' && 'z' <= newChar) || ('A' <= letter && 'Z' <= newChar))
            {
                newChar -= (char)26;
            }

            return newChar;
        }

        return letter;        
    }
}