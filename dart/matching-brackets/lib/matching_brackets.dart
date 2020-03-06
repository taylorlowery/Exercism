class MatchingBrackets {
  // Put your code here
  var bracketSets = {
    "[":"]",
    "{" : "}",
    "(" : ")"
  };
  var leftBrackets = ["[", "{", "("];
  var rightBrackets = ["]", "}", ")"];

  RegExp isBracket = new RegExp(r"[\[\]\{\}\(\)]");

  bool isPaired(String input){
    List<String> brackets = input.replaceAll(' ', '').split('').where((b) => isBracket.hasMatch(b)).toList();
    return listIsPaired(brackets);
  }

  bool listIsPaired(List<String> brackets){
    if(brackets.length == 0){
      return true;
    }

    for(int i = 0; i < brackets.length; i++){
      if(rightBrackets.contains(brackets[i])){ // iterate until the first right-bracket found
        if(i == 0){
          return false; // if the very first bracket is a right-bracket, fails
        }
        for(int j = i - 1; j >= 0; j--){
          if(leftBrackets.contains(brackets[j])){ // count backwards from first right-bracket to first left-bracket
            if(matchedSet(brackets[j], brackets[i])){ // if first left-bracket matches right-bracket
              List<String> remainingBrackets = [];
              for(int k = 0; k < brackets.length; k++){
                if(k != i && k != j){
                  remainingBrackets.add(brackets[k]);
                }
              }
              return listIsPaired(remainingBrackets); // re-run test on remaining chars
            }
            else{
              return false; // brackets were not a match, return false;
            }
          }
        }
      }
    }
    return false; // got all the way through and no right brackets -- fails
  }

  bool matchedSet(String leftBracket, String rightBracket){
    return bracketSets[leftBracket] == rightBracket;
  }
}
