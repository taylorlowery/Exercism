import 'dart:math';

class ArmstrongNumbers {
  bool isArmstrongNumber(int digit) {
    if (digit > 0 && digit < 10) {
      return true;
    } else if (9 < digit && digit < 100) {
      return false;
    } else {
      List<int> digits = [];
      digit
          .toString()
          .split('')
          .forEach((String d) => {digits.add(int.parse(d))});

      int sum = digits.fold(0, (int a, int b) {
        return a + pow(b, digits.length) as int;
      });
      return sum == digit;
    }
  }
}
