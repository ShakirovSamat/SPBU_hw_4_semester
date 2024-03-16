module Program

let isEven number = 
    if number % 2 = 0 then
        1
    else
        0

let getAmountOfEvenNumbersByMapFunction list =
    list
    |> List.map isEven
    |> List.sum

let getAmountOfEvenNumbersByFilterFunction list =
    list
    |> List.filter (fun x -> x % 2 = 0)
    |> List.length

let getAmountOfEvenNumbersByFoldFunction list =
    (0, list)
    ||> List.fold (fun s v -> s + isEven v)

