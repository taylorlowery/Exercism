class Anagram {
  Set getSetOfChars(String word) => Set.from(word.toLowerCase().split(''));
  bool isSubSet(Set wordSet, Set wordSet2) =>
      (wordSet.length == wordSet2.length && wordSet.containsAll(wordSet));
  bool isWordSubset(String word, String word2) =>
      isSubSet(getSetOfChars(word2), getSetOfChars(word2));
  List<String> findAnagrams(String word, List<String> possibleAnagrams) {
    List<String> anagrams = [];

    possibleAnagrams.forEach((f) {
      if (isWordSubset(word, f)) {
        anagrams.add(f);
      }
    });

    return anagrams;
  }
}
