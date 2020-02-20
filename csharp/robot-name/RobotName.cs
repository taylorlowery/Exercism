using System;
using System.Collections.Generic;

public static class RobotRegistry
{
    public static int NameLoopCount = 0;
    public static HashSet<string> TheNamesOfAllRobots = new HashSet<string>();
}

public class Robot
{
    private string _name;

    private Random _rnd = new Random();

    public Robot()
    {
        Reset();
    }

    public string Name
    {
        get
        {
            if (String.IsNullOrWhiteSpace(_name))
            {
                Reset();
            }

            return _name;
        }
    }

    public void Reset()
    {
        char a = (char)_rnd.Next(65, 91);
        char b = (char)_rnd.Next(65, 91);
        string digits = _rnd.Next(100, 1000).ToString();
        string name = $"{a}{b}{digits}";
        if (RobotRegistry.TheNamesOfAllRobots.Add(name))
        {
            _name = name;
        }
        else
        {
            RobotRegistry.NameLoopCount++;
            Reset();
        }
    }
}