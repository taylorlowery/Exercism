class Luhn {
  bool valid(String cardNumber){
    // remove spaces
    RegExp exp = new RegExp(r"([ ])");
    cardNumber = cardNumber.replaceAll(exp, '');

    // check for non digit characters
    RegExp nonDigit = new RegExp(r"\D+");
    if(nonDigit.hasMatch(cardNumber)){
      return false;
    }

    // make sure it's at least two nubmers long
    if(cardNumber.length < 2){
      return false;
    }

    // finally check the number
    List<int> numbers = cardNumberToList(cardNumber);
    numbers = luhnizedNumber(numbers);
    int sum = numbers.fold(0, (a, b) => (a + b));
    if(sum % 10 == 0){
      return true;
    }
    return false;
  }

  List<int> cardNumberToList(String cardNumber){

    List<int> numbers = [];
    var stringNums = cardNumber.split('');
    for (var value in stringNums) {
      var val = int.parse(value);
      numbers.add(val);
    }
    return numbers;
  }

  List<int> luhnizedNumber(List<int> numbers){
    for (int i = numbers.length - 2; i >= 0 ; i--){
      if(i.isEven){
        numbers[i] *= 2;
        if (numbers[i] > 9){
          numbers[i] -= 9;
        }
      }
    }
    return numbers;
  }
}
