open System
[<EntryPoint>]
let main(args : string[]) = 
  [ for i in 1 .. (int32)args.[0] -> i] 
  |> List.filter (fun (x) -> x%3 = 0 || x%5 = 0) 
  |> List.sum
  |> Console.Write 
  0
