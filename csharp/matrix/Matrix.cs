using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Matrix
{
    private IEnumerable<IEnumerable<int>> _matrix { get; set; }

    public Matrix(string input) => _matrix = input.Split('\n')
                                        .Select(r => r.Split(' '))
                                        .Select(r => r.Select(int.Parse));


    public int Rows => _matrix.Count();

    // for the purposes of this exercise, I'll assume they're all the same length
    public int Cols => _matrix.First().Count();

    public IEnumerable<int> Row(int row) => _matrix.ElementAt(row - 1).ToArray();

    public IEnumerable<int> Column(int col) => _matrix.Select(r => r.ElementAt(col - 1)).ToArray();

}