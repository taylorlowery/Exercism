def get_factors(number):
    return [x for x in range(1, int(number / 2 + 1)) if number % x == 0]


def classify(number):
    factors = get_factors(number)
    sum_factors = sum(factors)
    if sum_factors == number:
        return "perfect"
    elif sum_factors > number:
        return "abundant"
    elif sum_factors < number:
        return "deficient"
