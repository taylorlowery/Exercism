class NthPrime {
  int prime(int index) {
    if (index < 1) {
      throw new ArgumentError('There is no zeroth prime');
    }
    List<int> primes = [2];

    while (primes.length < index){
      for(int i = 2; i <= primes.last / 2 + 1; i++){
        bool prime = true;
        if ()
      }
    }

    return primes[index - 1];
  }
}
