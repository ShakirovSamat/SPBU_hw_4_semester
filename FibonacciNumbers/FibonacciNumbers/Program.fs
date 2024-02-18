let rec getFibonacchiNumber n =
    let rec inner list acc =
        if n = acc then
            List.head list
        else
            inner (list[0] + list[1]::list) (acc + 1)
    inner [1;0] 2

printfn $"%A{getFibonacchiNumber 45}"