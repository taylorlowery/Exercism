def is_armstrong_number(number):
    if number < 10:
        return True
    if number < 100:
        return False

    numString = str(number)
    sumNum = sum([x ** len(numString) for x in numString.split('')])
    return sumNum == number
