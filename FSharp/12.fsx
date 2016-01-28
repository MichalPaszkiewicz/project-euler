open System
open System.Reflection

[<EntryPoint>]
let main(args : string[]) =
  let getDivisors num =
    [ for i in 1..num -> i ]
    |> List.filter(fun n -> num % n = 0)
    |> List.length
  let getNthTriangular n =
    let nList = [ for i in 1..n -> i ]
    List.fold (fun state x -> state + x) 0 nList
  let rec testNext testNum divisorsNeeded =
    let triNum = getNthTriangular testNum
    if (getDivisors triNum) >= divisorsNeeded then
      printfn "%d" triNum |> ignore
    else
      testNext (testNum + 1) divisorsNeeded
    |> ignore
  let divsNeeded = (int)args.[0]
  testNext 1 divsNeeded
  0
// need to improve speed, possibly deal with longs
