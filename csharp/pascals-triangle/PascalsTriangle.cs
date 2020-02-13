using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            yield return buildRow(i);
        }
    }

    public static IEnumerable<int> buildRow(int row)
    {
        yield return 1;
        int column = 1;

        for (int j = 1; j < row; j++)
        {
            column = column * (row - j) / j;
            yield return column;
        }
    }
}