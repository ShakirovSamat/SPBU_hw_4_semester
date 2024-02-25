let factorial n =
    if n = 0 then
        1
    else
        let rec inner number acc =
            if acc = n then
                number
            else
                inner (number * (acc + 1)) (acc + 1)
        inner 1 0

printfn $"%A{factorial 0}"
            