namespace name_util

module NameFunctions =
    let averageLetterImperative(names: string list) =
        if names.Length = 0 then 0.0 else
        let mutable total = 0
        for name in names do
            total <- total + name.Length
        float total / float names.Length

    let averageLetterFunctional(names: string list) =
        match names with
        | [] -> 0.0
        | _ -> float (names |> List.sumBy(fun (name) -> name.Length)) / float names.Length

    let startLetterCountImperative(names: string list) =
        let counts = new System.Collections.Generic.Dictionary<char,int>()
        for name in names do
           counts.[name.[0]] <- if(counts.ContainsKey(name.[0])) then counts.[name.[0]] + 1 else 1
        counts

    let startLetterCountFunctional(names: string list) =
        names |> Seq.countBy(fun name -> name.[0])
              |> dict
