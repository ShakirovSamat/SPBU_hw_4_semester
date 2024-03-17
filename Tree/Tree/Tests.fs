module Tests
open Program
open FsUnit
open NUnit.Framework

[<Test>]
let ``MapTreeTestMultipleByTwo`` () =
    let tree = Tree (1,
                    Tree(2,
                        Tip(4), Tip(5)
                        ),
                    Tree(3,
                        Tip(6), Tip(7)
                        )
                    )
    let expectedTree = Tree (2,
                            Tree(4,
                                Tip(8), Tip(10)
                                ),
                            Tree(6,
                                Tip(12), Tip(14)
                                )
                            )
    let result = TreeMap (fun x -> x * 2) tree
    result |> should equal expectedTree

[<Test>]
let ``TreeMapTestPow`` () =
    let tree = Tree (1,
                    Tree(2,
                        Tip(4), Tip(5)
                        ),
                    Tree(3,
                        Tip(6), Tip(7)
                        )
                    )
    let expectedTree = Tree (1,
                            Tree(4,
                                Tip(16), Tip(25)
                                ),
                            Tree(9,
                                Tip(36), Tip(49)
                                )
                            )
    let result = TreeMap (fun x -> x * x) tree
    result |> should equal expectedTree