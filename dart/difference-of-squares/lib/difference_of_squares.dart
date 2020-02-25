import 'dart:math';

class DifferenceOfSquares {
  // Put your code here
  int square(int i) => i * i;
  int sum(int a, int b) => a + b;
  List<int> range(int val) => List<int>.generate(val, (int i) => i + 1);
  int sumOfSquares(int val) => range(val).map(square).reduce(sum);
  int squareOfSum(int val) => square(range(val).reduce(sum));
  int differenceOfSquares(int val) => squareOfSum(val) - sumOfSquares(val);
}
