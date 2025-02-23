module ParseTree
    // Discriminated unions for parse tree.
    type Value =
        |Number of int
        |Addition of Value * Value
        |Multiplication of Value * Value
        |Subtraction of Value * Value
        |Division of Value * Value

    // Parse tree with operations addition, multiplication, substraction and division
    let rec parse data =
        match data with
        |Number number -> Some number
        |Addition (number1, number2) ->
            match parse number1, parse number2 with
                | Some number1, Some number2 -> Some (number1 + number2)
                | _, _ -> None
        |Multiplication (number1, number2) ->
            match parse number1, parse number2 with
                | Some number1, Some number2 -> Some (number1 * number2)
                | _, _ -> None
        |Subtraction (number1, number2) ->
            match parse number1, parse number2 with
                | Some number1, Some number2 -> Some (number1 - number2)
                | _, _ -> None
        |Division (number1, number2) ->
            match parse number1, parse number2 with
                | Some number1, Some number2 ->
                    if number2 = 0 then
                        None
                    else
                        Some (number1 / number2)
                | _, _ -> None
