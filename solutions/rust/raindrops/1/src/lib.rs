pub fn raindrops(n: u32) -> String {
    let mut result_string: String = String::new();
    if n.is_multiple_of(3) {
        result_string.push_str("Pling");
    }
    if n.is_multiple_of(5) {
        result_string.push_str("Plang");
    }
    if n.is_multiple_of(7) {
        result_string.push_str("Plong");
    }
    if result_string.is_empty() {
        result_string = n.to_string();
    }
    result_string
}
