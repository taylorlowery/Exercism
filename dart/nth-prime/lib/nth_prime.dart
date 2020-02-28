class NthPrime {
  int prime(int index) {
    int primesFound = 0;

    if (index < 1) {
      throw new ArgumentError('There is no zeroth prime');
    }

    int counter = 1;
    while (primesFound < index) {
      counter++;
      if (isPrime(counter)) {
        primesFound++;
      }
    }
    return counter;
  }

  bool isPrime(int number) {
    for (int i = 2; i < number; i++) {
      if (number % i == 0) {
        return false;
      }
    }
    return true;
  }
}
