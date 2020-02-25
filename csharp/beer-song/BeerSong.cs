using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();
        while (takeDown > 0)
        {
            sb.Append(BottleVerse(startBottles));
            if (takeDown > 1)
            {
                sb.Append("\n");
                sb.Append("\n");
            }            
            takeDown--;
            startBottles = startBottles > 0 ? startBottles - 1 : 99; 
        }
        return sb.ToString();
    }

    public static string BottleVerse(int bottleCount) => $"{ VerseFirstLine(bottleCount) }\n{ VerseSecondLine(bottleCount) }";

    public static string VerseFirstLine(int bottleCount)
    {
        string bottleLine = BottlesLine(bottleCount);
        return $"{ bottleLine } of beer on the wall, { bottleLine.ToLower() } of beer.";
    }
        
    public static string VerseSecondLine(int bottleCount)
    {
        if (bottleCount > 0)
        {
            return $"Take { (bottleCount > 1 ? "one" : "it") } down and pass it around, { BottlesLine(bottleCount - 1).ToLower() } of beer on the wall.";
        }
        else
        {
            bottleCount = 99;
            return $"Go to the store and buy some more, { BottlesLine(bottleCount) } of beer on the wall.";
        }        
    }

    public static string BottlesLine(int bottleCount)
    {
        if (bottleCount > 0)
        {
            if (bottleCount == 1)
            {
                return $"1 bottle";
            }
            else
            {
                return $"{ bottleCount } bottles";
            }
        }
        else
        {
            return $"No more bottles";
        }
    }
}