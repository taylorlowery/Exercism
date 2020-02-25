import 'package:collection/collection.dart';

class Hamming {
  int distance(String strand1, String strand2) {
    int hammingDistance = 0;
    if (strand1.length == 0 && strand1.length == strand2.length) {
      return 0;
    }
    if (strand1.length == 0 || strand2.length == 0) {
      throw new ArgumentError('no strand must be empty');
    }
    if (strand1.length != strand2.length) {
      throw new ArgumentError("left and right strands must be of equal length");
    }
    hammingDistance = new IterableZip([strand1.runes, strand2.runes])
        .where((l) => l.first != l.last)
        .length;
    return hammingDistance;
  }
}
