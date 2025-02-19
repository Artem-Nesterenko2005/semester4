let fibonacci number =
    if number < 0 then
        failwith "Error: a negative number"
    let rec fibonacciCount first second counter =
        if counter >= number then
            first
        else
            fibonacciCount (first + second) (first) (counter + 1)
    fibonacciCount 0 1 0

printfn "%A" (fibonacci 5)
