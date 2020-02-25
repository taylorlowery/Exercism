class ResistorColorDuo {
  List<String> colors = [
    'black',
    'brown',
    'red',
    'orange',
    'yellow',
    'green',
    'blue',
    'violet',
    'grey',
    'white'
  ];

  int colorCode(String color) => colors.indexOf(color);

  int value(List<String> inputColors) {
    int firstIndex = colorCode(inputColors[0]);
    int secondIndex = colorCode(inputColors[1]);
    return int.parse('$firstIndex$secondIndex');
  }
}
