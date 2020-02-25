
def to_rna(dna_strand):

    dna_nucleotides = "GCTA"
    rna_nucleotides = "CGAU"

    return dna_strand.translate(str.maketrans(dna_nucleotides, rna_nucleotides))


