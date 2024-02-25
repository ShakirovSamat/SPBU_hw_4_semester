let rec getFibonacchiNumber n =
    if n = 1 then
        0
    elif n = 2 then
        1
    else
        let rec inner list acc =
            if n = acc then
                List.head list
            else
                inner (list[0] + list[1]::list) (acc + 1)
        inner [1;0] 2

printfn $"%A{getFibonacchiNumber 4}"