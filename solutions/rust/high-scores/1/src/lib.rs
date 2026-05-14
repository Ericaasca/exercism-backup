#[derive(Debug)]
pub struct HighScores {
    score_list: Vec<u32>,
}

impl HighScores {
    pub fn new(scores: &[u32]) -> Self {
        HighScores {
            score_list: scores.to_vec(),
        }
    }

    pub fn scores(&self) -> &[u32] {
        self.score_list.as_slice()
    }

    pub fn latest(&self) -> Option<u32> {
        self.score_list.last().copied()
    }

    pub fn personal_best(&self) -> Option<u32> {
        self.score_list.iter().max().copied()
    }

    pub fn personal_top_three(&self) -> Vec<u32> {
        let mut score_copy = self.score_list.clone();
        score_copy.sort_unstable_by(|a, b| b.cmp(a));
        score_copy.into_iter().take(3).collect()
    }
}
