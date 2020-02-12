
divisors = [
    (3, "Pling"),
    (5, "Plang"),
    (7, "Plong")
]


def convert(number):

    rain_sounds = ""
    for divisor, sound in divisors:
        if number % divisor == 0:
            rain_sounds += sound

    return rain_sounds if len(rain_sounds) > 0 else str(number)
