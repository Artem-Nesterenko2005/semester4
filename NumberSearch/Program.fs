let numberSearch number list =
    let rec exploreList list i =
        if list = [] then
            -1
        else
            if List.head list = number then
                i
            else
                exploreList (List.tail list) (i + 1)
    exploreList list 0

let a = [3;2;5;4]
printfn "%A" (numberSearch 5 a)
