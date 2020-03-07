class SecretHandshake {
  var shakeMoves = [
    "wink",
    "double blink",
    "close your eyes",
    "jump",
  ];
  List<String> commands(int combo) {
    List<String> moves = [];

    String binaryString = combo.toRadixString(2);
    binaryString.split('').reversed.toList().asMap().map((k, v) {
      if (k == 4) {
        moves = moves.reversed.toList();
      }
      if (v == "1") {
        moves.add(shakeMoves[k]);
      }
      return MapEntry(k, v);
    });

    return moves;
  }
}
