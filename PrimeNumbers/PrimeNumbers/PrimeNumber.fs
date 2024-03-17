module PrimeNumber

let isPrime number =
    let rec helper number acc =
        if acc = 1 then
            true
        elif number % acc = 0 then
            false
        else
            helper number (acc - 1)
    helper number (number - 1)

let rec getNextPrimeNunmber number =
    if isPrime (number + 1) then
        (number + 1)
    else 
        getNextPrimeNunmber (number + 1)

let primeNumbers = Seq.unfold (fun state -> Some(state, getNextPrimeNunmber state)) 2
