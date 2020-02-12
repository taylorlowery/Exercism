using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int, int, int)> triplets = new List<(int, int, int)>();

        for (int i = 1; i < sum - 3; i++)
        {
            for (int j = i + 1; j < sum - 2 ; j++)
            {
                int k = sum - j - i;

                if (i + j + k == sum)
                {
                    if(Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2))
                    {
                        triplets.Add((i, j, k));
                    }
                }
            }
        }

        return triplets;
    }
}