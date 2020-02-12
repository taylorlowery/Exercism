class BeerSong {
  List<String> recite(int bottleCount, int verses){
    List<String> lines = [];

    while(verses > 0){

      if (bottleCount > 0){

        if(bottleCount == 1){
          lines.add('$bottleCount bottle of beer on the wall, $bottleCount bottle of beer.');
        }
        else {
          lines.add('$bottleCount bottles of beer on the wall, $bottleCount bottles of beer.');
        }

        --bottleCount;
        if(bottleCount > 1){

          lines.add('Take one down and pass it around, $bottleCount bottles of beer on the wall.');
        }
        else if(bottleCount == 1){
          lines.add('Take one down and pass it around, $bottleCount bottle of beer on the wall.');
        }
        else {
          lines.add('Take it down and pass it around, no more bottles of beer on the wall.');
        }

        --verses;
        if(verses > 0)
        {
          lines.add('');
        }

        lines.addAll(recite(bottleCount, verses));
      }
      else {
        lines.add('No more bottles of beer on the wall, no more bottles of beer.');
        lines.add('Go to the store and buy some more, 99 bottles of beer on the wall.');
        --verses;
        lines.addAll(recite(99, verses));
      }
    }

    return lines;
  }

}
