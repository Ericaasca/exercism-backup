pub fn square(s: u32) -> u64 {
    let mut grain_in_square: u64 = 1;
    if s == 1 {
        grain_in_square as u64
    } else {
        for _ in 1..=s - 1 {
            grain_in_square = grain_in_square * 2;
        }
        grain_in_square
    }
}

pub fn total() -> u64 {
    let total_squares: u32 = 64;
    let mut total_in_squares: u64 = 0;
    for number in 1..=total_squares {
        total_in_squares += square(number as u32);
    }
    total_in_squares
}
