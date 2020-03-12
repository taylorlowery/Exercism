class Hamming {

    String LeftStrand;
    String RightStrand;

    Hamming(String leftStrand, String rightStrand) {
        LeftStrand = leftStrand;
        RightStrand = rightStrand;
    }

    int getHammingDistance() {
        int hammingDistance = 0;
        for(int i = 0; i < LeftStrand.length(); i++){
            if(LeftStrand.charAt(i) != RightStrand.charAt(i)){
                hammingDistance++;
            }
        }
        return hammingDistance;
    }
}
