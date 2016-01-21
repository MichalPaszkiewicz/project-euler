open System

[<EntryPoint>]
let main(args : string[]) =
  let n = (float)args.[0]
  let mutable primeTest = (int)(ceil(n * log(n) + n * (log(log(n)) - 1.0)))
  let primeMax = (int)(ceil(n * log(n) + n * log(log(n))))
  let isPrime number =
    [for i in [2..(int)(floor(sqrt ((float)number)))] -> i] |> List.forall(fun x -> number % x <> 0)
  while primeTest < primeMax do
    if isPrime(primeTest) then
      Console.WriteLine primeTest
    primeTest <- primeTest + 1
  0
//this gets a list of prime numbers that includes the nth prime number.
//very fast, but does not give an indication as to which number is the nth prime
