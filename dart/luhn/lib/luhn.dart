class Luhn {
  bool valid(String cardNumber){
    // remove spaces
    cardNumber = cardNumber.replaceAll(' ', '').replaceAll('-', '');

    // check for non digit characters
    RegExp nonDigit = new RegExp(r"\D+");
    if(nonDigit.hasMatch(cardNumber)){
      return false;
    }

    // make sure it's at least two numbers long
    if(cardNumber.length < 2){
      return false;
    }

    // finally check the number
    List<int> numbers = cardNumberToList(cardNumber);
    numbers = luhnizedNumber(numbers);
    int sum = numbers.fold(0, (a, b) => (a + b));
    return sum % 10 == 0;
  }

  List<int> cardNumberToList(String cardNumber){

    return cardNumber.split('')
                      .map((c) => int.parse(c))
                      .toList();
  }

  List<int> luhnizedNumber(List<int> numbers){
    return numbers
            .asMap()
            .map((key, value) {
              if(key % 2 == 0){
                return MapEntry(key, value);
              }
              else{
                var newVal = value * 2;
                return MapEntry(key, (newVal > 9 ? newVal - 9 : newVal));
              }
            })
            .values
            .toList();
  }
}
