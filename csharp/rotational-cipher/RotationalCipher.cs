using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class RotationalCipher
{
    public static Regex regex = new Regex(@"[a-zA-Z]");

    public static string Rotate(string text, int shiftKey)
    {
        char RotateChar(Char c)
        {
            if (!char.IsLetter(c))
                return c;
            
            if (shiftKey % 26 == 0)
                return c;

            int baseChar = char.IsLower(c) ? 'a' : 'A';
            return (char)(baseChar + ((c - baseChar + shiftKey) % 26));            
        }

        return string.Concat(text.Select(RotateChar));
    }
}