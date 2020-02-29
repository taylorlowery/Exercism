using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private string _word { get; set; }
    private string _sortedWord { get; set; }


    public Anagram(string baseWord)
    {
        _word = baseWord.ToLower();
        _sortedWord = SortedString(_word);
    }

    public IEnumerable<string> FindAnagrams(string[] potentialMatches) => potentialMatches
        .Where(p => p.ToLower() != _word).Where(p => SortedString(p) == _sortedWord).ToList();

    public string  SortedString(String word) => new string(word.ToLower().OrderBy(c => c).ToArray());
}