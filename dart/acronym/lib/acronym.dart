class Acronym {
  String abbreviate(String name){
    RegExp punct = new RegExp(r"[^A-Za-z']+");
    String accro = name.toUpperCase().split(punct).fold('', (String a, String b) => (a + b[0]));
    return accro;
  }
}
