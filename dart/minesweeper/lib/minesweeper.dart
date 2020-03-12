class Minesweeper {
  List<List<String>> board;

  Minesweeper(List<String> boardArr){
    this.board = parseBoard(boardArr);
  }

  List<List<String>> parseBoard(List<String> boardArr){
    List<List<String>> board = [];
    boardArr.forEach((f) => board.add(f.split('')));
    return board;
  }

  List<String> annoted(){
    return [""];
  }

  String tileNum(List<String> board){
    int val = 0;
    for(int i = 0; i < board.length; i++){
      for(int j = 0; j < board[i].length; j++){

        // above

        // below

        // left

        // right


      }
    }

    return val.toString();
  }
 }
