let factorial number =
    if number < 0 then
        failwith "Error: a negative number"
    let rec factorialCount number result =
        if number <= 1 then
            result
        else
            factorialCount (number - 1) (result * number)

    factorialCount number 1

printfn "%A" (factorial 6)