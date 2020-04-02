def is_isogram(string):
    clean_string = string.lower().replace(' ', '').replace('-', '')
    return len(set(clean_string)) == len(clean_string)
