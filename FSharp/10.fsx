open System
open System.Reflection

[<EntryPoint>]
let main(args : string[]) =
  let seqTryHead s = Seq.tryPick Some s
  let argInt = (int)args.[0]
  let primes = Array.append [|0;0|] [|2..argInt|]
  let rec filterPrime p = 
    seq {for mul in (p*2)..p..argInt do 
            yield mul}
        |> Seq.iter (fun mul -> primes.[mul] <- 0)
    let nextPrime = 
        seq { 
            for i in p+1..argInt do 
                if primes.[i] <> 0 then 
                    yield primes.[i]
        }
        |> seqTryHead
    match nextPrime with
        | None -> ()
        | Some np -> filterPrime np
  filterPrime 2
  let filteredPrimes = primes |> Seq.filter(fun x -> x <> 0) |> Seq.toList
  printfn "%A" (List.fold (fun acc x -> acc + x) 0 filteredPrimes)
  0
// eratosthenes sieve, then fold
