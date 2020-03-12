import math


def score(x, y):
    radius = hypoteneuse(x, y)
    if radius > 10:
        return 0
    elif radius > 5:
        return 1
    elif radius > 1:
        return 5
    else:
        return 10


def hypoteneuse(a, b):
    return math.sqrt(a**2 + b**2)
