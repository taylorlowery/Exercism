using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect, // sum of all factors less than the number equals the number
    Abundant, // sum of all factors less than the number is greater than the number
    Deficient // sum of all factors less than the number is less than the number
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException();
        }

        int factorSum = GetFactors(number).Sum();

        if (factorSum == number)
        {
            return Classification.Perfect;
        }
        else if (factorSum < number)
        {
            return Classification.Deficient;
        }
        else
        {
            return Classification.Abundant;
        }
    }

    public static List<int> GetFactors(int number)
    {
        List<int> factors = new List<int>();

        int counter = 1;
        while (counter < number)
        {
            if (number % counter == 0)
            {
                factors.Add(counter);
            }
            counter++;
        }
        
        return factors;
    }
    
    
    // This one is slick but it seems to be about 30% slower
    public static List<int> GetFactorsButLooksCooler(int number) => 
        Enumerable.Range(1, number - 1).Where(n => number % n == 0).ToList();
}
