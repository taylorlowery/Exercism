using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private List<(string name, int grade)> _roster { get; set; } = new List<(string, int)>();

    public void Add(string student, int grade) => _roster.Add((student, grade));

    public IEnumerable<string> Roster() => _roster.OrderBy(s => s.grade).ThenBy(s => s.name).Select(s => s.name);

    public IEnumerable<string> Grade(int grade) =>
        _roster.Where(s => s.grade == grade).OrderBy(s => s.name).Select(s =>s.name);
}