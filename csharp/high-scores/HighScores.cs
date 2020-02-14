using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores;

    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores() => new List<int>(_scores);

    public int Latest() => _scores.LastOrDefault();

    public int PersonalBest() => _scores.Max();

    public List<int> PersonalTopThree() => _scores.OrderByDescending(s => s).Take(3).ToList();
}