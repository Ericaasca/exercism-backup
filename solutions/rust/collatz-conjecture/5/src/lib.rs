pub fn collatz(n: u64) -> Option<u64> {
    let mut number_of_operations: u64 = 0;
    let mut current_number: u64 = n;
    if n == 0 {
        return None;
    }
    while current_number != 1 {
        if current_number.is_multiple_of(2) {
            current_number /= 2;
        }
        else {
            current_number *= 3;
            current_number += 1;
        }
        number_of_operations += 1;
    }
    Some(number_of_operations)
}
