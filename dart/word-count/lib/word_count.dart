class WordCount {
  Map<String, int> countWords(String words) {
    Map<String, int> results = new Map();
    List<String> cleanWords =
        words.replaceAll(new RegExp(r"(\p{P})"), '').split(' ');
    for (String word in cleanWords) {
      if (results.containsKey(word)) {
        results[word] = results[word] + 1;
      } else {
        results[word] = 1;
      }
    }
    return results;
  }
}
