class Diamond {
  // Put your code here
  var alphabet = "abcdefghijklmnopqrstuvwxyz".toUpperCase().split('');

  List<String> rows(String letter) {
    List<String> lines = [];
    int index = alphabet.indexOf(letter);
    while (index >= 0) {
      lines.add(row(alphabet[index]));
      index--;
    }
    return lines;
  }

  String row(String letter) {
    int index = alphabet.indexOf(letter);
    String buffer = " " * index;
    String line = buffer + letter + buffer;
    print(line);
    return line;
  }
}
