pub fn reverse(input: &str) -> String {
    let mut reverse = String::with_capacity(input.len());
    for letter in input.chars().reverse() {
        reverse.push(letter);
    }
    return reverse;
}
