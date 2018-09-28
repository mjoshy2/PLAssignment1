use std::collections::HashMap;

extern crate itertools;

use itertools::Itertools;

pub fn average_letter_imperative(names: Vec<String>) -> f32 {
    return if names.len() == 0 {0.0} else {
        let mut total = 0.0;
        for name in &names {
            total += name.len() as f32;
        }
        let average = total as f32 / names.len() as f32;
        (average * 100.0).round() /100.0
    }
}

pub fn average_letter_functional(names: &Vec<String>) -> f32 {
    return if names.len() == 0 {0.0} else {
        let total = names.into_iter()
                          .map(|name| name.len())
                          .fold(0,|acc, length| acc+length);
        let average = total as f32 / names.len() as f32;
        (average * 100.0).round() /100.0
    }
}

pub fn start_letter_count_imperative(names: &Vec<String>) -> HashMap<String, i32> {
    let mut dict = HashMap::new();

    for name in names {
        let count = dict.entry(name[0..1].to_string()).or_insert(0);
        *count += 1;
    }
    return dict;
}

pub fn start_letter_count_functional(names:&Vec<String>) -> HashMap<String, i32> {
    names.iter()
         .group_by(|name| name[0..1].to_string())
         .into_iter()
         .map(|(name, group)| (name, group.count() as i32))
         .collect()
}
