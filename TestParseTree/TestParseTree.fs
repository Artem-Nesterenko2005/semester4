module TestParseTree

open NUnit.Framework
open FsUnit
open ParseTree

[<TestFixture>]
module Tests =

    [<Test>]
    let ``The usual example`` () =
        parse (Division(Number(6), Number(3))) |> should equal (Some(2))

    [<Test>]
    let ``The big example`` () =
        parse (Addition(Multiplication(Number(3), Number(5)), Subtraction(Number(5), Number(1)))) |> should equal (Some(19))

    [<Test>]
    let ``Division by zero`` () =
        parse (Division(Number(2), Number(0))) |> should equal None

    [<Test>]
    let ``Division by zero in big example`` () =
        parse (Addition(Multiplication(Number(3), Division (Number(5), Number(0))), Subtraction(Number(5), Number(1)))) |> should equal None
