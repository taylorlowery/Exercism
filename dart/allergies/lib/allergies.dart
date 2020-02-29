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
    var n = Allergens[allergen];
    return n & score > 0;
  }

  List<String> list(int score) {
    return Allergens.keys.where((k) => allergicTo(k, score)).toList();
  }
}
