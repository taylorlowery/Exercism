using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{    
    public static string TranslateSubStrandToProtein(string strand)
    {
        switch (strand)
        {
            case "AUG":
                return "Methionine";
            case "UUU":
            case "UUC":
                return "Phenylalanine";
            case "UUA":
            case "UUG":
                return "Leucine";
            case "UCU":
            case "UCC":
            case "UCA":
            case "UCG":
                return "Serine";
            case "UAU":
            case "UAC":
                return "Tyrosine";
            case "UGU":
            case "UGC":
                return "Cysteine";
            case "UGG":
                return "Tryptophan";
            case "UAA":
            case "UAG":
            case "UGA":
            default:
                return "STOP";
        }
    }

    public static string[] Proteins(string strand)
    {
        //return ConvertStrandToProteinsWithLoop(strand);
        return ConvertStrandToProteinsWithLinq(strand);
    }

    public static string[] ConvertStrandToProteinsWithLoop(string strand)
    {
        HashSet<string> proteins = new HashSet<string>();

        for (int i = 0; i <= strand.Length - 3; i += 3)
        {
            string subStrand = strand.Substring(i, 3);
            var protein = TranslateSubStrandToProtein(subStrand);
            if (protein.Equals("STOP"))
            {
                break;
            }
            proteins.Add(protein);
        }

        return proteins.ToArray();
    }

    // pretty much copied from michalszewa's solution at https://exercism.io/tracks/csharp/exercises/protein-translation/solutions/821e39ee1341420aafb48140240c6c1e
    public static string[] ConvertStrandToProteinsWithLinq(string strand)
    {
        return strand
                .Select((s, i) => i)
                .Where(i => i % 3 == 0)
                .Select(i => strand.Substring(i, 3))
                .TakeWhile(s => TranslateSubStrandToProtein(s) != "STOP")
                .Select(s => TranslateSubStrandToProtein(s))
                .ToArray();
    }
}