class Matrix:
    def __init__(self, matrix_string):
        self.matrix = []
        for row in matrix_string.split('\n'):
            self.matrix.append([int(i) for i in row.split(' ')])

    def row(self, index):
        return self.matrix[index - 1]

    def column(self, index):
        return [row[index - 1] for row in self.matrix]
