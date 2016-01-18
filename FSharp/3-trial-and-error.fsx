open System
open System.Reflection

[<EntryPoint>]
let main(args : string[]) =
  let seqTryHead s = Seq.tryPick Some s
  let argInt = (int)args.[0]
  let halfArg = (int)(ceil( (float)args.[0] / 2.0 ))
  let primes = Array.append [|0;0|] [|2..halfArg|]
  let rec filterPrime p = 
    seq {for mul in (p*2)..p..halfArg do 
            yield mul}
        |> Seq.iter (fun mul -> primes.[mul] <- 0)
    let nextPrime = 
        seq { 
            for i in p+1..halfArg do 
                if primes.[i] <> 0 then 
                    yield primes.[i]
        }
        |> seqTryHead
    match nextPrime with
        | None -> ()
        | Some np -> filterPrime np
  filterPrime 2
  let filteredPrimes = primes |> Seq.filter(fun x -> x <> 0) |> Seq.toList |> List.filter (fun(x) -> argInt % x = 0 )
  printfn "%A" filteredPrimes
  0
// get primes with eratosthenes sieve, then trial and error.
// only works to int32 bounds 
