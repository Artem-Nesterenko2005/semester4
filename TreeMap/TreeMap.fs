module TreeMap
    // A binary tree data structure.
    type 'a Tree = 
    | Leaf of 'a
    | Node of 'a * 'a Tree * 'a Tree

    // A function that applies a function to each element of the tree, returning a new tree.
    let rec map func tree =
        match tree with
        | Leaf(data) -> Leaf(func(data))
        | Node(data, left, right) -> 
            Node(func(data), map func left, map func right)
