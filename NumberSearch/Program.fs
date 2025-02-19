let numberSearch number list =
    let rec exploreList list i =
        if list = [] then
            None
        else
            if List.head list = number then
                Some(i)
            else
                exploreList (List.tail list) (i + 1)
    exploreList list 0

let list = [3; 2; 5; 4]
printfn "%A" (numberSearch 5 list)
