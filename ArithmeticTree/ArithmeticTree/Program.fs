open Tree
open NUnit.Framework
open FsUnit

[<Test>]
let ``ArithmetictreeSimpleTest`` () =
    let tree = ArithmeticTree(Addition, Number(2), Number(2))
    let expectedResult = 4
    let result = calculateArithmeticTree tree
    result |> should equal expectedResult

[<Test>]
let ``ArithmetictreeComplexTest`` () =
    // (625 / 5 ) + (-1 + 5) - (5 * 5) = 125 - 21 = 104
    let tree = ArithmeticTree(Addition,
                    ArithmeticTree(Division, Number(625), Number(5)),
                    ArithmeticTree(Subtraction,
                        ArithmeticTree(Multiplication, Number(5), Number(5)), 
                        ArithmeticTree(Addition, Number(-1), Number(5))))
    let expectedResult = 104
    let result = calculateArithmeticTree tree
    result |> should equal expectedResult

