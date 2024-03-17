module Tree

type Operations =
    | Addition
    | Subtraction
    | Multiplication
    | Division

type ArithmeticTree<'a> = 
    | Number of 'a
    | ArithmeticTree of Operations * ArithmeticTree<'a> * ArithmeticTree<'a>

let rec calculateArithmeticTree tree = 
    match tree with
    | Number x -> x
    | ArithmeticTree (operation, left, right) ->
        match operation with
        | Addition -> calculateArithmeticTree left + calculateArithmeticTree right
        | Subtraction -> calculateArithmeticTree left - calculateArithmeticTree right
        | Multiplication -> calculateArithmeticTree left * calculateArithmeticTree right
        | Division -> calculateArithmeticTree left / calculateArithmeticTree right
