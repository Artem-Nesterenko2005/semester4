module PointFree

let func'1 x l = List.map (fun y -> y * x) l

let func'2 x : (int) list -> (int) list = List.map (fun y -> y * x)

let func'3 x : (int) list -> (int) list = List.map ((*) x)
