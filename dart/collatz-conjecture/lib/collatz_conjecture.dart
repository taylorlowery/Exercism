class CollatzConjecture {
  int halve(int n) => n ~/ 2;
  int collatz(int n) => (3 * n) + 1;
  int steps(int input) {
    int stepCount = 0;

    if (input < 1) {
      throw new ArgumentError('Only positive numbers are allowed');
    }

    while (input != 1) {
      input = input.isEven ? halve(input) : collatz(input);
      stepCount++;
    }

    return stepCount;
  }
}
