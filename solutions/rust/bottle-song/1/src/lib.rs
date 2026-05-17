use ::std::fmt::Write;
fn number_to_word(num: u32) -> &'static str {
    match num {
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eight",
        9 => "Nine",
        10 => "Ten",
        _ => "",
    }
}

fn bottle_plural(num: u32) -> &'static str {
    match num {
        1 => "bottle",
        _ => "bottles",
    }
}

pub fn recite(start_bottles: u32, take_down: u32) -> String {
    let mut result_song: String = String::new();
    let mut current_bottles: u32 = start_bottles;
    for _ in 1..=take_down {
        write!(
            result_song,
            "{} green {} hanging on the wall,\n",
            number_to_word(current_bottles),
            bottle_plural(current_bottles)
        )
        .unwrap();
        write!(
            result_song,
            "{} green {} hanging on the wall,\n",
            number_to_word(current_bottles),
            bottle_plural(current_bottles)
        )
        .unwrap();
        write!(
            result_song,
            "And if {} green bottle should accidentally fall,\n",
            number_to_word(1).to_lowercase()
        )
        .unwrap();
        current_bottles -= 1;
        if current_bottles == 0 {
            write!(
                result_song,
                "There'll be no green bottles hanging on the wall.\n",
            )
            .unwrap();
        } else {
            write!(
                result_song,
                "There'll be {} green {} hanging on the wall.\n\n",
                number_to_word(current_bottles).to_lowercase(),
                bottle_plural(current_bottles)
            )
            .unwrap();
        }
    }
    result_song
}
