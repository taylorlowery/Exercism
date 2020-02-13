using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>> triangle = new List<List<int>>();

        while (triangle.Count() < rows)
        {
            var nextRow = triangle.Count() > 0 ? buildRow(triangle.Last()) : new List<int>() { 1 };
            triangle.Add(nextRow);
        }

        return triangle;
    }

    public static List<int> buildRow(IEnumerable<int> previousRow)
    {
        int[] newRow = new int[previousRow.Count() + 1];

        for (int i = 0; i < newRow.Count(); i++)
        {
            int n1 = i - 1 >= 0 ? previousRow.ElementAt(i - 1) : 0;
            int n2 = i < previousRow.Count() ? previousRow.ElementAt(i) : 0;
            newRow[i] = n1 + n2;
        }

        return newRow.ToList();
    }

}