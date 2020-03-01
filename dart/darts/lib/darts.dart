import 'dart:math';

class Darts {
  int score(double x, double y) {
    double distance = pythagoreanLength(x, y);
    if (distance > 10) {
      return 0;
    }
    if (distance > 5) {
      return 1;
    }
    if (distance > 1) {
      return 5;
    }
    return 10;
  }

  double pythagoreanLength(double x, double y) {
    return sqrt(pow(x, 2) + pow(y, 2));
  }
}
