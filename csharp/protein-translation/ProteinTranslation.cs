using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{    
    public static string _proteinSwitch(string strand)
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
        HashSet<string> proteins = new HashSet<string>();

        for (int i = 0; i <= strand.Length-3; i+=3)
        {
            string subStrand = strand.Substring(i, 3);
            var protein = _proteinSwitch(subStrand);
            if (protein.Equals("STOP"))
            {
                break;
            }
            proteins.Add(protein);
        }

        return proteins.ToArray();
    }
}