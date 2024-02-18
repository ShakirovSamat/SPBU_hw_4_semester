let factorial n = 
    let rec inner number acc =
        if acc = n then
            number
        else
            inner (number * acc) (acc + 1)
    inner 1 1

printfn $"%A{factorial 10}"
            