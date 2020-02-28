class PhoneNumber {
  String clean(String phoneNumber) {
    RegExp nonDigit = new RegExp(r'(\D)');
    RegExp punctuation = new RegExp(r'([,\/#!$%\^&\*;:{}=\_`~])');
    RegExp wordCharacter = new RegExp(r'([A-Za-z])');

    if (punctuation.hasMatch(phoneNumber)) {
      throw new FormatException('punctuations not permitted');
    }

    if (wordCharacter.hasMatch(phoneNumber)) {
      throw new FormatException('letters not permitted');
    }

    //  Convert to a string
    String cleanNumber = phoneNumber.replaceAll(nonDigit, "");

    if (cleanNumber.length < 10) {
      throw new FormatException('incorrect number of digits');
    }
    if (cleanNumber.length > 11) {
      throw new FormatException('more than 11 digits');
    }

    if (cleanNumber.length == 11) {
      if (cleanNumber[0] != '1') {
        throw new FormatException('11 digits must start with 1');
      } else {
        cleanNumber = cleanNumber.substring(1);
      }
    }

    if (cleanNumber[0] == '0') {
      throw new FormatException('area code cannot start with zero');
    }
    if (cleanNumber[0] == '1') {
      throw new FormatException('area code cannot start with one');
    }
    if (cleanNumber[3] == '0') {
      throw new FormatException('exchange code cannot start with zero');
    }
    if (cleanNumber[3] == '1') {
      throw new FormatException('exchange code cannot start with one');
    }

    return cleanNumber;
  }
}
