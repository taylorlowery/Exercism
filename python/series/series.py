def slices(series, length):
    if length < 1 or len(series) < length:
        raise ValueError("Impossible!")
    results = [series[i:i + length] for i in range(0, len(series) - length + 1)]
    return results
