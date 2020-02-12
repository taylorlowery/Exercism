using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        //  I've read that a dictionary has better performance than a switch statement (see below_
        Dictionary<char,char> DnaToRnaDict = new Dictionary<char, char>
        {
            {'G', 'C'},
            {'C', 'G'},
            {'T', 'A'},
            {'A', 'U'}
        };
        // non-linq?
        char[] arrna = new char[nucleotide.Length];

        for (int i = 0; i < nucleotide.Length; i++)
        {
            // here we could do some error handling to make sure it's a valid nucleotide?
            // That we're not getting a Q or something
            arrna[i] = DnaToRnaDict[nucleotide[i]];
        }
        
        return new string(arrna);
    }

    // The other way I might have converted the individual chars
    public static char DnaToRna(char dnaChar)
    {
        switch (dnaChar)
        {
            case 'G':
                return 'C';
            case 'C':
                return 'G';
            case 'T':
                return 'A';
            case 'A':
                return 'U';
            default:
                // shouldn't be possible
                return 'X';
        }
    }
}