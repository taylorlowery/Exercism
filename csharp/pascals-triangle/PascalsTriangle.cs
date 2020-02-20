using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<IEnumerable<int>> triangle = new List<IEnumerable<int>>();

        while (triangle.Count() < rows)
        {
            yield return buildRow(new List<int>());
        }

    }

    public static IEnumerable<int> buildRow(IEnumerable<int> previousRow)
    {
        yield return 1;

        for (int i = 0; i < previousRow.Count() + 1; i++)
        {
            int n1 = i - 1 >= 0 ? previousRow.ElementAt(i - 1) : 0;
            int n2 = i < previousRow.Count() ? previousRow.ElementAt(i) : 0;
            yield return n1 + n2;
        }
    }

}