class Bob {
  // Put your code here
  String response(String input) {
    input = input.trim();
    RegExp hasWord = new RegExp(r"[a-zA-Z]");
    if (input.trim().length == 0) {
      return 'Fine. Be that way!';
    }

    if (hasWord.hasMatch(input) && input == input.toUpperCase()) {
      // all caps
      if (input.endsWith('?')) {
        // question
        return 'Calm down, I know what I\'m doing!';
      } else {
        return 'Whoa, chill out!';
      }
    } else {
      // not all caps
      if (input.endsWith('?')) {
        // question
        return 'Sure.';
      } else {
        return 'Whatever.';
      }
    }
  }
}
