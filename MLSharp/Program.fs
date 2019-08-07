

open System
open System.IO
open Deedle

[<EntryPoint>]
let main argv =
    let root = Directory.GetCurrentDirectory().Replace("MLSharp", "").Replace("bin\\Debug\\netcoreapp2.2", "")
    let frame = Frame.ReadCsv(Path.Combine(root+"MLPython\\char2idx.csv"), hasHeaders=false)
    printfn "%s" ""
    0 // return an integer exit code
