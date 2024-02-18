let rec pow value power =
    if power = 0 then
        1
    elif power = 1 then
        value
    elif power % 2 = 0 then
        pow (value * value) (power / 2)
    else
        value * pow (value * value) ((power - 1) / 2)

// Первый вариант решения. Громозкий, но зато выполняется наименьшее количество операций возведения в степень
let createList n m =
    let rec inner lst acc = 
        if acc = n + m + 1 then
            lst

        elif acc = n then
            inner ((pow 2 acc)::lst) (acc + 1)
        else
            inner (((List.head lst) * 2)::lst) (acc + 1)
    inner [] n

printfn $"%A{(List.rev (createList 5 13))}"

//Второе пример решения. Короче, но выполняется чуть больше операций возведения в степень
let otherCreateList n m =
    List.unfold (fun state -> if state > (pow 2 (n + m)) then None else Some(state, state * 2)) (pow 2 n)

printfn $"%A{(otherCreateList 5 13)}"

