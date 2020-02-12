using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static int ToInt(char c) => (int)Char.GetNumericValue(c);

    public static bool IsArmstrongNumber(int number)
    {
        // getting rid of negatives
        if (number < 0)
        {
            return false;
        }
        // single digit numbers are armstrong numbers
        else if (number < 10)
        {
            return true;
        }
        // no double digit armstrong numbers exist
        else if (number < 100)
        {
            return false;
        }
        else
        {
            string num = number.ToString();
            int sum = ((int)(num.Select(ToInt)
                        .Select(b => Math.Pow(b, num.Length))
                        .Sum()));
            return sum == number;
        }
    }
}