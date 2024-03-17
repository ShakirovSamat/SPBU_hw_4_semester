open PrimeNumber
open FsUnit
open NUnit.Framework

[<Test>]
let ``10FirstPRimeNumbersTest`` () =
    let result = Seq.take 10 primeNumbers
    let expected = [2;3;5;7;11;13;17;19;23;29]

    result |> should equal expected

[<Test>]
let ``getBigPrimeNumberTest`` () =
    let result = Seq.item 200 primeNumbers
    let expected = 1223
    
    result |> should equal expected
