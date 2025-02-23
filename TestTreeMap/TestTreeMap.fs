module TestTreeMap

open NUnit.Framework
open FsUnit
open TreeMap

[<TestFixture>]
module Tests =

    [<Test>]
    let ``The usual example`` () =
        let rightTree = Node(11, Leaf 4, Leaf 7)
        map (fun x -> x + 2) (Node (9, Leaf 2, Leaf 5)) |> should equal rightTree

    [<Test>]
    let ``The big tree example`` () =
        let rightTree = (Node (12, Node (9, Node (18, Leaf 27, Leaf 3), Leaf 6), Leaf 12))
        map (fun x -> x * 3) (Node (4, Node (3, Node (6, Leaf 9, Leaf 1), Leaf 2), Leaf 4)) |> should equal rightTree
