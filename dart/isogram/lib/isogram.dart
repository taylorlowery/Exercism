class Isogram {
  bool isIsogram(String word) {
    String filtered = word.toLowerCase().replaceAll(new RegExp(r"\W"), '');
    return filtered.split('').toSet().length == filtered.length;
  }

  bool myOriginalSolution(String word) {
    // when I made this, I had forgotten about sets.
    RegExp regExp = RegExp(r"(\w)");
    Map<String, int> charCounts = new Map();
    bool iso = true;

    for (String c in word.toLowerCase().split('')) {
      if (regExp.hasMatch(c)) {
        if (charCounts.containsKey(c)) {
          iso = false;
          break;
        } else {
          charCounts[c] = 1;
        }
      }
    }
    return iso;
  }
}
