def leap_year(year):
    return (year % 4 == 0 and not(year % 100 == 0 and year % 400 != 0))


'''
on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400
'''