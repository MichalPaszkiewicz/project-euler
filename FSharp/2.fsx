open System
[<EntryPoint>]
let main(args : string[]) = 
  let rec addEmUp a b c =
    let newB = a + b
    if newB < (int32)args.[0] then
      if newB%2 = 0 then
        addEmUp b newB (c + newB)
      else
        addEmUp b newB c
    else
      printfn "%d" c
    |> ignore
  addEmUp 1 1 0
  0
