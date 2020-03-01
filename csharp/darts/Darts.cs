using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double hypotenuse = Hypotenuse(x, y);
        if (hypotenuse > 10)
        {
            return 0;
        }

        if (hypotenuse > 5)
        {
            return 1;
        }

        if (hypotenuse > 1)
        {
            return 5;
        }

        return 10;
    }

    public static double Hypotenuse(double x, double y) => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
}
