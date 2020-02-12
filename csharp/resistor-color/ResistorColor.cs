using System;

public static class ResistorColor
{
    private static string[] _resistorColors;

    public static int ColorCode(string color)
    {
        if (_resistorColors == null)
        {
            _resistorColors = Colors();
        }
        return Array.IndexOf(_resistorColors, color);
    }

    public static string[] Colors(){
        return new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}