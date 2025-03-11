open System.Collections.Generic

let checkBracketSequence sequence =
    let stack = Stack<char>();

    let oppositeBracket bracket = 
        match bracket with
        | '}' -> stack.Count > 0 && stack.Peek()  = '{'
        | ')' -> stack.Count > 0 && stack.Peek() = '('
        | ']' -> stack.Count > 0 && stack.Peek() = '['
        | _ -> false

    let rec check sequence =
        match Seq.tryHead sequence with
        | Some('{') | Some('(') | Some('[') ->
            stack.Push(Seq.head sequence)
            check (Seq.skip 1 sequence)

        | Some('}') | Some(')') |Some(']') -> 
            if oppositeBracket (Seq.head sequence) then
                stack.Pop() |> ignore
                check (Seq.skip 1 sequence)
            else
                false
        | None -> stack.Count = 0

        | _ -> check (Seq.skip 1 sequence)

    check sequence
