open System

[<EntryPoint>]
let main(args : string[]) =
  let isPrime number =
    [for i in [2..(int)(floor(sqrt ((float)number)))] -> i] |> List.forall(fun x -> number % x <> 0)
  let mutable primeCount = 1
  let mutable testNum = 2
  let expectedPrimes = (int)args.[0]
  while primeCount < expectedPrimes do
    testNum <- testNum + 1
    if (isPrime testNum) then
      primeCount <- primeCount + 1
  Console.Write testNum
  0
