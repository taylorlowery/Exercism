using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        if (multiples.Count() == 0 || max < multiples.Min())
        {
            return 0;
        }
        
        int sum = 0;
        List<int> allMultiples = new List<int>();
        var maxRange = Enumerable.Range(0, max).Where(n => n >= multiples.Min()).ToList();
        foreach (var num in maxRange)
        {
            foreach (var divisor in multiples.Where(m => m > 0))
            {
                if (num % divisor == 0)
                {
                    allMultiples.Add(num);
                    break;
                }
            }
        }

        sum =  allMultiples.Sum();

        return sum;
    }
}