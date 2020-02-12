class PhoneNumber {
  String clean(String phoneNumber){
    RegExp nonNumber = new RegExp(r"\D");
    RegExp punct = new RegExp(r"\p{P}-[()-]");
    RegExp letters = new RegExp(r"[a-zA-Z]");
    String cleanedPhoneNumber = phoneNumber.replaceAll(nonNumber, '');

    // remove if the number of characters is wrong.
    if (cleanedPhoneNumber.length < 9){
      throw FormatException('incorrect number of digits');
    }
    else if (cleanedPhoneNumber.length > 11){
      throw FormatException('more than 11 digits');
    }
    else if (letters.hasMatch(phoneNumber)){
      throw FormatException('letters not permitted');
    }
    else if (punct.hasMatch(phoneNumber)){
      throw FormatException('punctuations not permitted');
    }

    // check country code and remove if valid
    if(cleanedPhoneNumber.length == 11){
      if(!cleanedPhoneNumber.startsWith('1')){
        throw FormatException('11 digits must start with 1');
      }
      cleanedPhoneNumber = cleanedPhoneNumber.substring(1);
    }
    if(cleanedPhoneNumber.startsWith('0')){
      throw FormatException('area code cannot start with zero');
    }
    if (cleanedPhoneNumber.startsWith('1')){
      throw FormatException('area code cannot start with one');
    }
    if(cleanedPhoneNumber[3] == '0'){
      throw FormatException('exchange code cannot start with zero');
    }
    if(cleanedPhoneNumber[3] == '1'){
      throw FormatException('exchange code cannot start with one');
    }

    return cleanedPhoneNumber;
  }
}
