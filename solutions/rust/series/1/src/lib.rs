pub fn series(digits: &str, len: usize) -> Vec<String> {
    let digits_len: usize = digits.chars().count();
    let mut results: Vec<String> = Vec::new();
    for i in 0..digits_len {
        if i + len > digits_len {
            break;
        }
        let result_string: String = digits[i..len+i].to_string();
        results.push(result_string);
    }
    results
}
