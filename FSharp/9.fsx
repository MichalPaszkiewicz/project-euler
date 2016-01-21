open System

[<EntryPoint>]
let main(args : string[]) =
  Console.WriteLine "\nsearching..."
  let testValsWork a b expectedVal =
    let rooted = sqrt(a*a + b*b)
    if (rooted = round(rooted)) then
      if (a + b + rooted = expectedVal) then
        printfn "\na: %.0f  b: %.0f  c: %.0f  abc: %.0f" a b rooted (a*b*rooted)
  let testOptions a expectedVal =
    [for i in [1.0..expectedVal] -> i]
    |> List.iter (fun x -> testValsWork a x expectedVal)
  let argNum = (float)args.[0]
  [for i in [1.0..argNum] -> i]
  |> List.iter (fun x -> testOptions x argNum)
  Console.WriteLine "\nsearch finished"
  0
