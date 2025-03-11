module TestPointFree

open NUnit.Framework
open PointFree
open FsCheck
open FsUnit

[<TestFixture>]
module Tests =

    [<Test>]
    let ``Common example``() =
       func'3 2 [1;3;5] |> should equal [2;6;10]

    [<Test>]
    let ``FsCheck check functions``() =
        let comparisonFunctions x list =
            (func'1 x list = func'2 x list) && (func'2 x list = func'3 x list)
        Check.QuickThrowOnFailure comparisonFunctions
