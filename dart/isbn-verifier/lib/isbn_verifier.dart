class IsbnVerifier {}

bool isValid(String isbn) {
  isbn = isbn.replaceAll('-', '');
  RegExp nonDigit = new RegExp(r"\D");
  // check length
  if (isbn.length != 10) {
    return false;
  }
  // check for characters in first characters
  if (nonDigit.hasMatch(isbn.substring(0, 8))) {
    return false;
  }
  // make sure last character is int or X
  if (nonDigit.hasMatch(isbn[9]) && !isbn.endsWith('X')) {
    return false;
  }

  int isbnSum = isbn
      .split('')
      .asMap()
      .map((k, v) {
        if (v == "X") {
          v = "10";
        }
        int i = int.parse(v) * (k + 1);
        return MapEntry(k, i);
      })
      .values
      .fold(0, (int a, int b) => (a + b));

  return isbnSum % 11 == 0;
}
