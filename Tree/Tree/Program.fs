module Program

type Tree<'a> = 
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec TreeMap mapFunction tree  =
    match tree with
    | Tree (value, l, r) -> Tree(mapFunction value, TreeMap mapFunction l, TreeMap mapFunction r)
    | Tip value -> Tip(mapFunction value)