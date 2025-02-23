module TestEvenNumbers

open NUnit.Framework
open FsUnit
open EvenNumbers
open FsCheck

[<TestFixture>]
module Tests =

    [<Test>]
    let ``MapEvenNumbers usual test`` () = 
        mapEvenNumbers([1; 5; -2; 4; -9; 3]) |> should equal 2

    [<Test>]
    let ``FilterEvenNumbers usual test``() = 
        filterEvenNumbers([3; 4; -11; -2; 5; 1]) |> should equal 2

    [<Test>]
    let ``FoldEvenNumbers usual test``() = 
        foldEvenNumbers([-6; 7; 2; 1; -5; 9]) |> should equal 2

    [<Test>]
    let ``FsCheck check functions``() =
        let comparisonFunctions list =
            (mapEvenNumbers list = filterEvenNumbers list) && (filterEvenNumbers list = foldEvenNumbers list)
        Check.QuickThrowOnFailure comparisonFunctions
