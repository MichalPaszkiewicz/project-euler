open System
open System.Reflection

[<EntryPoint>]
let main(args : string[]) =
  let getProduct(strOfNums: string) =
    let x = [ for c in strOfNums -> (int)c - 48]
    List.fold (fun state xi -> state * xi) 1 x
  let searchForMaxProduct (numberString:string, digitLength:int) =
    let maxTry = numberString.Length - digitLength
    let options = [ for i in 0..maxTry -> (numberString.Substring(i, digitLength)) ]
    [ for s in options -> getProduct(s) ]
    |> List.max
  let productLength = (int)args.[0]
  let numString = (string)args.[1]
  searchForMaxProduct(numString, productLength) |> Console.WriteLine
  0
