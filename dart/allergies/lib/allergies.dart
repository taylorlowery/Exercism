class Allergies {
  Map<String, int> Allergens = {
    'eggs': 1,
    'peanuts': 2,
    'shellfish': 4,
    'strawberries': 8,
    'tomatoes': 16,
    'chocolate': 32,
    'pollen': 64,
    'cats': 128
  };

  bool allergicTo(String allergen, int score) {
    return list(score).contains(allergen);
  }

  List<String> list(int score) {
    List<String> allergens = [];

    Allergens.forEach((k, v) {
      if (v & score > 0) {
        allergens.add(k);
      }
    });

    return allergens;
  }
}
