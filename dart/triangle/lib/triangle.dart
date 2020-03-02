class Triangle {

  // all three sides have the same length
  bool equilateral (double a, double b, double c){
    if(checkIfTriangle(a, b, c)){
      if(a == b && b == c){
        return true;
      }
    }

    return false;
  }

  // any two sides are the same, but not the 3rd
  bool isosceles (double a, double b, double c){
    if (checkIfTriangle(a, b, c)){
      if((a == b) ||
          (a == c) ||
          (b == c)){
        return true;
      }
    }

    return false;
  }

  // no two sides have same length
  bool scalene (double a, double b, double c){
    if(checkIfTriangle(a, b, c)){
      if(a != b && a != c && b != c){
        return true;
      }
    }

    return false;
  }

  // checks to see if it's even possible these sides could be a triangle
  bool checkIfTriangle(double a, double b, double c){
    List<double> sides = [a, b, c];

    // all sides must have positive length
    if(sides.any((s) => (s <= 0))){
      return false;
    }

    // sum of two sides must be greater than the third.
    if((a + b < c) || (a + c < b) || (b + c < a)){
      return false;
    }

    return true;
  }
}
