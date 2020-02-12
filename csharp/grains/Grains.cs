using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n > 0 && n < 65)
        {
            return ((ulong)Math.Pow(2, (n - 1)));
        }

        throw new ArgumentOutOfRangeException();
    }

    public static ulong Total()
    {
        ulong total = 1;
        ulong prev = 1;
        int counter = 1;

        while (++counter < 65)
        {
            prev = prev * 2;
            total += prev;
        }

        return total;
    }
}