_colors = [
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white",
        ]


def value(colors):
    return int(str(color_index(colors[0])) + str(color_index(colors[1])))


def color_index(color):
    return _colors.index(color)
