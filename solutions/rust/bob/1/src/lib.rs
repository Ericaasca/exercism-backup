pub fn reply(message: &str) -> &str {
    match message.trim() {
        x if x.ends_with("?") && x == &x.to_uppercase() && x.chars().any(|c| c.is_alphabetic()) => {
            "Calm down, I know what I'm doing!"
        }
        x if x.ends_with("?") => "Sure.",
        x if x.chars().any(|c| c.is_alphabetic()) && x == &x.to_uppercase() => "Whoa, chill out!",
        x if x.is_empty() => "Fine. Be that way!",
        _ => "Whatever.",
    }
}
