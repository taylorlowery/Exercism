class PascalsTriangle {
  List<List<int>> rows(int rowCount) {
    List<List<int>> triangle = [];

    while (triangle.length < rowCount) {
      var nextRow = triangle.length > 0 ? buildRow(triangle.last) : [1];
      triangle.add(nextRow);
    }
    return triangle;
  }

  List<int> buildRow(List<int> previousRow) {
    List<int> newRow = new List<int>(previousRow.length + 1);

    for (int i = 0; i < newRow.length; i++) {
      int n1 = i - 1 >= 0 ? previousRow[i - 1] : 0;
      int n2 = i < previousRow.length ? previousRow[i] : 0;
      newRow[i] = n1 + n2;
    }
    return newRow;
  }
}
