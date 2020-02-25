class Pangram {
  var alphabet = "abcdefghijklmnopqrstuvwxyz".split('');
  bool isPangram(String input) {
    Set<String> formattedInput = input.toLowerCase().split('').toSet();
    bool pangram = true;
    int index = 0;
    while (index < alphabet.length) {
      String letter = alphabet[index];
      if (!(formattedInput.contains(letter))) {
        pangram = false;
        break;
      }
      index++;
    }
    return pangram;
  }
}
