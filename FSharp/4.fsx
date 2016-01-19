open System

[<EntryPoint>]
let main(args : string[]) =
  let isPalindromic(s: string) = 
    let reverse = System.String(Array.rev(s.ToCharArray()))
    s = reverse
  let getMaxPalindromeMultiple multiple maxNum =
    List.append [1] [for i in [1..maxNum] -> i * multiple] 
    |> List.filter (fun(x) -> isPalindromic(x.ToString())) 
    |> List.max
  let argNum = (int)args.[0]
  [for j in 1..argNum -> getMaxPalindromeMultiple j argNum]
  |> List.max |> Console.Write
  0
