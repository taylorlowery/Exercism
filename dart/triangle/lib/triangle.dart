class Triangle {
  bool equilateral(double a, double b, double c) {
    return (a > 0 && (a == b) && (a == c));
  }

  bool isosceles(double a, double b, double c) {
    if ((a > 0) && (b > 0) && (c > 0)) {}

    return false;
  }

  bool scalene(double a, double b, double c) {}

  bool checkSides(double a, double b, double c) {
    List<double> sides = [a, b, c];
    sides.sort();
    if (sides.any((s) => (s <= 0))) {
      return false;
    }
    if (sides[0] + sides[1] < sides[2]) {
      return false;
    }

    return true;
  }
}
