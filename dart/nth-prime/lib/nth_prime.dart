import 'dart:math';

class NthPrime {
  int prime(int index) {
    //  track the number of primes that have been found
    //  this way we avoid the memory issue of  tracking a huge list of numbers as index -> infinity
    int primesFound = 0;

    if (index < 1) {
      throw new ArgumentError('There is no zeroth prime');
    }

    // as this counter increases, we'll check if it's prime, and count the number of primes
    // we can start at 1, because the first prime is 2.
    int counter = 1;
    while (primesFound < index) {
      counter++;
      if (isPrime(counter)) {
        primesFound++; // if the counter is prime, increase the count of primes found
      }
    }
    return counter; // once you've found the nth prime, return the counter
  }

  bool isPrime(int number) {
    // unfortunately have to loop from 1 up to see if number has any divisors
    // however, you only have to iterate up to sqrt of number
    for (int i = 2; i <= sqrt(number); i++) {
      if (number % i == 0) {
        return false; // if any number divides evenly, not prime
      }
    }
    return true; // woohoo, it's prime!
  }
}
