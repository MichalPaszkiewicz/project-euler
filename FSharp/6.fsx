open System

[<EntryPoint>]
let main(args : string[]) =
  let getSquares numList =
    numList |> List.map(fun(x) -> x * x) |> List.sum
  let getSquared numList =
    let numSum = numList |> List.sum
    numSum * numSum
  let theNumList = [for i in [1.. ((int)args.[0])]  -> i ]
  (getSquared(theNumList) - getSquares(theNumList)) |> Console.Write
  0
