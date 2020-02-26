using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();

        while (takeDown > 0)
        {
            sb.Append(Verse(startBottles));
            takeDown--;
            startBottles--;
            if (takeDown > 0)
            {
                sb.Append("\n\n");
            }
        }


        return sb.ToString();
    }


    public static string Verse(int bottleCount)
    {
        switch (bottleCount)
        {
            case 0:
                return "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
            case 1:
                return "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.";
            case 2:
                return $"2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.";
            default:
                return $"{ bottleCount } bottles of beer on the wall, { bottleCount } bottles of beer.\nTake one down and pass it around, { bottleCount - 1 } bottles of beer on the wall.";
        }
    }

    // the following is my original, over-engineered solution.
    // don't do it like this.
    public static string SingBeerSong(int startBottles, int takeDown)
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