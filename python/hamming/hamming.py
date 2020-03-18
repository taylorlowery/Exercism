def distance(strand_a, strand_b):
    if len(strand_a) != len(strand_b):
        raise ValueError("The strands must be of the same length.")
    stuff = [(x, y) for (x, y) in zip(list(strand_a), list(strand_b)) if x != y]
    return len(stuff)
