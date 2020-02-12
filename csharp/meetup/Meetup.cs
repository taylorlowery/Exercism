using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Sdk;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private List<DateTime> _daysInSelectedMonth;
    
    public Meetup(int month, int year)
    {
        _daysInSelectedMonth = Enumerable.Range(1, DateTime.DaysInMonth(year, month))
            .Select(day => new DateTime(year, month, day))
            .ToList();
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var selectedDays = _daysInSelectedMonth.Where(day => day.DayOfWeek == dayOfWeek).ToList();
        
        switch (schedule)
        {
            case Schedule.First:
                return selectedDays[0];
            case Schedule.Second:
                return selectedDays[1];
            case  Schedule.Third:
                return selectedDays[2];
            case Schedule.Fourth:
                return selectedDays[3];
            case Schedule.Last:
                return selectedDays.Last();
            case Schedule.Teenth:
                return selectedDays.FirstOrDefault(day => 13 <= day.Date.Day);
        }
        
        throw new ArgumentException();
    }
}