class Diamond {
  String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  List<String> rows(String letter) {
    int letterIndex = alphabet.indexOf(letter);
    int rowLength = letterIndex > 0 ? 1 : letterIndex + 3;
    int rowCount = 0;
    List<String> rows = [];

    while (rowCount < (letterIndex + 1)) {
      rows.add(row(rowCount, rowLength));
      rowCount++;
    }

    List<String> reversed = rows.reversed.skip(1).toList();

    return rows + reversed;
  }

  String row(int letterIndex, int rowLength) {
    if (letterIndex == 0) {
      return "A";
    }

    int outerSpace = ((rowLength - 3) / 2) as int;

    return alphabet[letterIndex].padLeft(outerSpace).padRight(letterIndex + 1) +
        alphabet[letterIndex].padRight(outerSpace);
  }
}
