class Hamming {
  // Put your code here
  int distance(String strand1, String strand2){
    int hamming = 0;

    for(int i = 0; i < strand1.length; i++){
      if (strand1[i] != strand2[i]){
        hamming++;
      }
    }

    return hamming;
  }
}
