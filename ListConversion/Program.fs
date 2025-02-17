let reverseList list =
    let rec copyList list newList =
        if list = [] then
            newList
        else
            copyList (List.tail list) (List.head list:: newList)
    copyList list []

printf "%A" (reverseList [1;2;3;4;5])
