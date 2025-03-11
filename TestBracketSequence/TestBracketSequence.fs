module TestBracketSequence

open NUnit.Framework
open FsUnit
open BracketSequence

[<TestFixture>]
module Tests =

    [<Test>]
    let ``Empty string example`` () =
        checkBracketSequence "        " |> should equal true

    [<Test>]
    let ``Simple right string example``() = 
        checkBracketSequence "([{}])()" |> should equal true

    [<Test>]
    let ``Wrong not pair string example``() = 
        checkBracketSequence "({}" |> should equal false

    [<Test>]
    let ``Wrong incorrectly nested string example``() = 
        checkBracketSequence "({)}" |> should equal false

    [<Test>]
    let ``Wrong open bracket string example``() = 
        checkBracketSequence "({" |> should equal false

    [<Test>]
    let ``Wrong closed bracket string example``() = 
        checkBracketSequence ")]" |> should equal false

    [<Test>]
    let ``Non brackets string example``() = 
        checkBracketSequence "12321412423" |> should equal true
