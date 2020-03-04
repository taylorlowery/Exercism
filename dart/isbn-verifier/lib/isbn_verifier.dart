class IsbnVerifier {
  bool isValid(String isbn) {
    return false;
  }
}

bool isValid(String isbn) {
  isbn = isbn.replaceAll("-", "");
  if (isbn.length != 10) {
    return false;
  }
  if (!(isbn.endsWith(r'\d') || (isbn.endsWith('X')))) {
    return false;
  }

  if (isbn.substring(0, isbn.length - 1).contains(r'\w')) {
    return false;
  }

  var nums = isbnInts(isbn);

  return false;
}

List<int> isbnInts(String isbn) {
  List<int> isbnInts = [];
  var chars = isbn.split('');
  for (int i = 0; i < chars.length; i++) {
    if (chars[i] == 'X') {
      isbnInts.add(10);
    } else {
      isbnInts.add(int.parse(chars[i]));
    }
  }
  return isbnInts;
}
