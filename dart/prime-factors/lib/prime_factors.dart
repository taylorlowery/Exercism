class PrimeFactors {
  List<int> factors(int number) {
    List<int> primeFactors = [];
    int factor = 2;
    while (number > 1) {
      while (number % factor != 0) {
        factor++;
      }
      primeFactors.add(factor);
      number = number ~/ factor;
    }
    return primeFactors;
  }
}
