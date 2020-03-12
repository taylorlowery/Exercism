class Minesweeper {
  List<List<String>> board = [];

  Minesweeper([List<String> setup]) {
    setup.forEach((f) {
      print(f);
      var subList = f.split('').toList();
      this.board.add(subList);
    });
  }

  bool isMine(int x, int y) => board[x][y] == '*';

  int rowSum(int i, int j) {
    int sum = 0;

    // j - 1
    if (j > 0) {
      if (isMine(i, j - 1)) {
        sum++;
      }
    }
    // j
    if (isMine(i, j)) {
      sum++;
    }

    // j + 1
    if (j < this.board[0].length - 1) {
      if (isMine(i, j + 1)) {
        sum++;
      }
    }

    return sum;
  }

  List<String> annoted() {
    List<List<String>> parsedBoard = this.board;

    for (int i = 0; i < this.board.length; i++) {
      for (int j = 0; j < this.board[i].length; j++) {
        if (parsedBoard[i][j] == ' ') {
          int sum = 0;

          // i - 1
          if (i > 0) {
            sum += rowSum(i - 1, j);
          }

          // i
          sum += rowSum(i, j);
          // i + 1
          if (i < this.board.length - 1) {
            sum += rowSum(i + 1, j);
          }

          parsedBoard[i][j] = sum > 0 ? sum.toString() : ' ';
        }
      }
    }

    return parsedBoard.map((l) => (l.join())).toList();
  }
}
