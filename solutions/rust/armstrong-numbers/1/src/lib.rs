fn convert_number_to_list(mut n: u32) -> Vec<u32> {
    let mut digits: Vec<u32> = Vec::new();
    if n == 0 {
        return vec![0];
    } else {
        while n > 0 {
            digits.push(n % 10);
            n /= 10;
        }
        digits.reverse();
        return digits;
    }
}

pub fn is_armstrong_number(num: u32) -> bool {
    let num_vector: Vec<u32> = convert_number_to_list(num);
    let vector_len: u32 = num_vector.len() as u32;
    let mut sum: u32 = 0;
    for digit in num_vector {
        sum += digit.pow(vector_len);
    }
    return sum.eq(&num);
}
