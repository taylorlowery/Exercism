using System;
using System.Diagnostics.CodeAnalysis;

public class Clock: IEquatable<Clock>
{
    private TimeSpan _clockTime;

    public TimeSpan ClockTime
    {
        get { return _clockTime; }
        set { _clockTime = value; }
    }


    public Clock(int hours, int minutes)
    {
        Add(hours * 60 + minutes);
    }

    public Clock Add(int minutesToAdd)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }


    public bool Equals([AllowNull] Clock other) => this.ClockTime == other.ClockTime;
}
