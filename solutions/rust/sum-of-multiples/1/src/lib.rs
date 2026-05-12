pub fn find_multiples_under_limit (limit: u32, number: u32) -> Vec<u32> {
    if number == 0 {
        return vec![0];
    }
    let multiples: Vec<u32> = (number..limit)
        .step_by(number as usize)
        .collect();
    multiples
}

pub fn sum_of_multiples(limit: u32, factors: &[u32]) -> u32 {
    let mut mult_list: Vec<u32> = Vec::new();
    for num in factors {
        mult_list.append(&mut find_multiples_under_limit(limit, *num));
    }
    mult_list.sort();
    mult_list.dedup();
    mult_list.iter().sum()
}