module EvenNumbers
    // Counts the number of even numbers in the list using the function map.
    let mapEvenNumbers list =
       List.length list - List.sum (List.map (fun x -> abs(x) % 2) list)

    // Counts the number of even numbers in the list using the function filter.
    let filterEvenNumbers list =
        List.length (List.filter (fun x -> abs(x) % 2 = 0) list)

    // Counts the number of even numbers in the list using the function fold.
    let foldEvenNumbers list =
        List.length list - List.fold (fun sum x -> sum + abs(x) % 2) 0 list
