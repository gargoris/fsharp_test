open System
open RomanNumerals.Library.Numerals


// For more information see https://aka.ms/fsharp-console-apps
[<EntryPoint>]
let Main (args) =
    if args.Length <> 1 then
        printfn "No values received"
        0
    else
        let (parsed, value) = Int32.TryParse args[0]

        if (not parsed) then
            printfn "Error: expecting int as argument"
            1
        else
            printfn $"Result for {args[0]}: {GetRomanNumeral value}"
            0
