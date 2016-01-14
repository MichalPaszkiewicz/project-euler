open System

[<EntryPoint>]
let main(args : string[]) =
  let rec superTest firstNum =
    let rec testForMaxPrime num startNum = 
      let remainderRoot = float(startNum * startNum - num) |> sqrt
      let roundedRemainder = round(remainderRoot)
      if remainderRoot = (float)roundedRemainder then
        let testFinalNum = ((int64)remainderRoot + startNum)
        if testFinalNum = num then
          printfn "%d" testFinalNum
        else
          superTest testFinalNum
      else
        if startNum > num then
          printfn "program ended manually"
        else
          let newStartNum = (int64)startNum + (int64)1
          testForMaxPrime num newStartNum
      |> ignore
    let root = ceil((float)firstNum |> sqrt)
    if (int64)args.[0]%((int64)4) = (int64)2 then
      printfn "%d" (int64((float)firstNum / 2.0))
    else
      testForMaxPrime ((int64)firstNum) ((int64)root)
    |> ignore
  superTest ((int64)args.[0])
  0
// does not find BIGGEST prime for the test number 600851475143. finds second biggest.
