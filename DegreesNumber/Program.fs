let exponentiation first second = 
    let rec addList list counter = 
        if counter <= second + first then
            if List.length list = 0 then
                addList (pown 2 counter::list) (counter + 1)
            else
                addList (List.item 0 list * 2::list) (counter + 1)
        else
            List.rev list
    addList [] first

printfn "%A" (exponentiation 8 4)
