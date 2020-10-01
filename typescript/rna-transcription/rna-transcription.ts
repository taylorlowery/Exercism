const dnaToRnaNucleotide = {
  G: "C",
  C: "G",
  T: "A",
  A: "U",
};

type Nucleotide = keyof typeof dnaToRnaNucleotide;

class Transcriptor {
  toRna(dnaStrand: String): String {
    let chars = dnaStrand.toUpperCase().split('');
    chars.map((c) => {
      if(c is Nucle)
    })
  }
  dnaToRna(dnaStrand: Nucleotide[]): String {
    return dnaStrand.map((d) => dnaToRnaNucleotide[d]).join("");
  }
}

export default Transcriptor;
