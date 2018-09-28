use std::collections::HashMap;

extern crate name_util;

    #[test]
    fn canary_test() {
        assert_eq!(true, true);
    }

    #[test]
    fn average_imperative_empty_list() {
        let expected = 0.0;
        let actual = name_util::average_letter_imperative(vec![]);
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_imperative_one_name() {
        let expected = 6.0;
        let actual = name_util::average_letter_imperative(["Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_imperative_different_length() {
        let expected = 7.5;
        let actual = name_util::average_letter_imperative(["venkat","notvenkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_imperative_same_length() {
        let expected = 6.0;
        let actual = name_util::average_letter_imperative(["Venkat","Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_imperative_lot_of_names() {
        let expected = 6.13;
        let actual = name_util::average_letter_imperative(["Abdon", "Brandon", "Christopher", "Daniel", "Denys", "Diego", "Edrienne", "Eugene", "Ezequiel",
    "Gustavo", "Houtan", "Jeffry", "Lina", "Luis", "Martin", "Matthew", "Mike", "Naresh", "Nicolas", "Patricio", "Pio", "Rachel", "Ravali", "Samad",
    "Shaneej", "Shara", "Sikender", "Tommy", "Venkat", "Victor", "Zachary"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_functional_empty_list() {
        let expected = 0.0;
        let actual = name_util::average_letter_functional(&vec![]);
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_functional_one_name() {
        let expected = 6.0;
        let actual = name_util::average_letter_functional(&["Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_functional_different_length() {
        let expected = 7.5;
        let actual = name_util::average_letter_functional(&["venkat","notvenkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_functional_same_length() {
        let expected = 6.0;
        let actual = name_util::average_letter_functional(&["Venkat","Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn average_functional_lot_of_names() {
        let expected = 6.13;
        let actual = name_util::average_letter_functional(&["Abdon", "Brandon", "Christopher", "Daniel", "Denys", "Diego", "Edrienne", "Eugene", "Ezequiel",
    "Gustavo", "Houtan", "Jeffry", "Lina", "Luis", "Martin", "Matthew", "Mike", "Naresh", "Nicolas", "Patricio", "Pio", "Rachel", "Ravali", "Samad",
    "Shaneej", "Shara", "Sikender", "Tommy", "Venkat", "Victor", "Zachary"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn imperative_names_starting_with_empty_list() {
        let expected = HashMap::new();
        let actual = name_util::start_letter_count_imperative(&vec![]);
        assert_eq!(expected,actual);
    }

    #[test]
    fn imperative_names_starting_with_one_name() {
        let expected: HashMap<_, _> = vec![("V".to_string(),1)].into_iter().collect();
        let actual = name_util::start_letter_count_imperative(&["Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn imperative_names_starting_with_names_of_same_size() {
        let expected: HashMap<_, _> = vec![("V".to_string(),2)].into_iter().collect();
        let actual = name_util::start_letter_count_imperative(&["Venkat","Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn imperative_names_starting_with_names_of_different_size() {
        let expected: HashMap<_, _> = vec![("V".to_string(),1),("n".to_string(),1)].into_iter().collect();
        let actual = name_util::start_letter_count_imperative(&["Venkat","notVenkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn imperative_names_starting_with_lots_of_names() {
        let expected: HashMap<_, _> = vec![("A",1), ("B",1), ("C",1), ("D",3), ("E",3) , ("G",1) , ("H",1) , ("J",1), ("L",2), ("M",3), ("N",2), ("P",2), ("R",2), ("S",4), ("T",1),
         ("V",2), ("Z",1)].into_iter().map(|s| ((s.0)[0..1].to_string(),s.1)).collect();
        let actual = name_util::start_letter_count_imperative(&["Abdon", "Brandon", "Christopher", "Daniel", "Denys", "Diego", "Edrienne", "Eugene", "Ezequiel",
    "Gustavo", "Houtan", "Jeffry", "Lina", "Luis", "Martin", "Matthew", "Mike", "Naresh", "Nicolas", "Patricio", "Pio", "Rachel", "Ravali", "Samad",
    "Shaneej", "Shara", "Sikender", "Tommy", "Venkat", "Victor", "Zachary"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn functional_names_starting_with_empty_list() {
        let expected = HashMap::new();
        let actual = name_util::start_letter_count_functional(&vec![]);
        assert_eq!(expected,actual);
    }

    #[test]
    fn functional_names_starting_with_one_name() {
        let expected: HashMap<_, _> = vec![("V".to_string(),1)].into_iter().collect();
        let actual = name_util::start_letter_count_functional(&["Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn functional_names_starting_with_names_of_same_size() {
        let expected: HashMap<_, _> = vec![("V".to_string(),2)].into_iter().collect();
        let actual = name_util::start_letter_count_functional(&["Venkat","Venkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn functional_names_starting_with_names_of_different_size() {
        let expected: HashMap<_, _> = vec![("V".to_string(),1),("n".to_string(),1)].into_iter().collect();
        let actual = name_util::start_letter_count_functional(&["Venkat","notVenkat"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }

    #[test]
    fn functional_names_starting_with_lots_of_names() {
        let expected: HashMap<_, _> = vec![("A",1), ("B",1), ("C",1), ("D",3), ("E",3) , ("G",1) , ("H",1) , ("J",1), ("L",2), ("M",3), ("N",2), ("P",2), ("R",2), ("S",4), ("T",1),
         ("V",2), ("Z",1)].into_iter().map(|s| ((s.0)[0..1].to_string(),s.1)).collect();
        let actual = name_util::start_letter_count_functional(&["Abdon", "Brandon", "Christopher", "Daniel", "Denys", "Diego", "Edrienne", "Eugene", "Ezequiel",
    "Gustavo", "Houtan", "Jeffry", "Lina", "Luis", "Martin", "Matthew", "Mike", "Naresh", "Nicolas", "Patricio", "Pio", "Rachel", "Ravali", "Samad",
    "Shaneej", "Shara", "Sikender", "Tommy", "Venkat", "Victor", "Zachary"].iter().map(|&s| s.into()).collect());
        assert_eq!(expected,actual);
    }
