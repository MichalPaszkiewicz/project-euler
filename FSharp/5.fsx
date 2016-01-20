open System

[<EntryPoint>]
let main(args : string[]) =
  let mutable runLoop = true
  let numList = [for i in [1..(int)args.[0]] -> i]
  let divisibleByAll (divisorList:int list) num =
    divisorList |> List.forall (fun (x) -> num%x = 0)
  let mutable tryNum = (int)args.[0]
  while runLoop do
    if(divisibleByAll numList tryNum) then
      runLoop <- false
      Console.Write tryNum
    else
      tryNum <- tryNum + 1
  0
// quite slow. would be quicker to get list of prime factors, then multiply through
