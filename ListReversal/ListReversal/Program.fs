let reverseList list = 
    let rec inner list acc =
        if list = [] then
            acc
        else
            inner (List.tail list) (List.head list::acc)
    inner list []

let list = [1;2;3;4;5;5]

printfn $"%A{reverseList list}"