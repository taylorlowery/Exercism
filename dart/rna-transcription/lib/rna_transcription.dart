class RnaTranscription {
  Map<String,String> dnaToRna = {
    'G': 'C',
    'C':'G',
    'T' : 'A',
    'A' : 'U'
  };
  Map<String, String> rnaToDna = {
    'C' : 'G',
    'G' : 'C',
    'A' :'T',
    'U' : 'A'
  };
  String toRNA(String DNA) {
    var rna = DNA.split('')
        .fold('', (String a, String b) => a + dnaToRna[b]);
    return rna;
  }
  String toDNA(String RNA){
    var dna = RNA.split('').fold('', (String a, String b) => a + rnaToDna[b]);
    return dna;
  }
}
