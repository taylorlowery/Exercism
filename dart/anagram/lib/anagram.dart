class Anagram {
  List<String> findAnagrams(String word, List<String> possibleAnagrams) {
    return possibleAnagrams.where((a) => isAnagram(word, a)).toList();
  }

  bool isAnagram(String firstWord, String secondWord) {
    return ((firstWord.length == secondWord.length) &&
        (wordToCharSet(firstWord).containsAll(wordToCharSet(secondWord))));
  }

  Set wordToCharSet(String word) {
    return Set<String>.from(word.toLowerCase().split(''));
  }
}
