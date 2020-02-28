class Anagram {
  List<String> findAnagrams(String word, List<String> possibleAnagrams) {
    return possibleAnagrams.where((a) => isAnagram(word, a)).toList();
  }

  bool isAnagram(String word, String possibleAnagram) {
    return ((word.length == possibleAnagram.length) &&
        (wordToCharSet(word).containsAll(wordToCharSet(possibleAnagram))));
  }

  Set wordToCharSet(String word) {
    return Set<String>.from(word.toLowerCase().split(''));
  }
}
