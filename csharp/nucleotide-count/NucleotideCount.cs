using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IReadOnlyDictionary<char, int> nucleotideCount = new Dictionary<char, int> {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}        
        };

    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> _nucleotideCount = new Dictionary<char, int>(nucleotideCount);

        for (int i = 0; i < sequence.Length; i++)
        {
            if (!nucleotideCount.ContainsKey(sequence[i]))
            {
                throw new ArgumentException($"Invalid nucleotide detected at index {i}: {sequence[i]}. Please use a valid sequence.");
            }

            _nucleotideCount[sequence[i]]++;
        }

        return _nucleotideCount;
    }
}