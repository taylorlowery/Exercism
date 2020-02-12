using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class DifferenceOfSquares
{
    static int Square(this int value) => value * value;
    static IEnumerable<int> GetRange(this int max) => Enumerable.Range(start: 1, count: max);

    public static int CalculateSquareOfSum(int max) => max.GetRange().Sum().Square()
;
    public static int CalculateSumOfSquares(int max) => max.GetRange().Select(Square).Sum();

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}