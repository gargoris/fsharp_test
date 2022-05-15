namespace RomanNumerals.Library

open System


module Numerals =

    let GetRomanNumeral (x: int) =
        let thousands x =
            let m = x / 1000
            let rest = x % 1000
            (String.replicate m "M", rest)

        let baseChar (b: char) = int b - int '0'

        let baseCase (maxLetter: string) midLetter lowerLetter x =
            if x > 0 then

                let roman =
                    match x with
                    | 9 -> lowerLetter + maxLetter
                    | 4 -> lowerLetter + midLetter
                    | _ when x > 4 -> midLetter + String.replicate (x - 5) lowerLetter
                    | _ -> String.replicate x lowerLetter

                roman
            else
                ""

        let fiveHundreds = baseCase "M" "D" "C"
        let fifties = baseCase "C" "L" "X"
        let fifhs = baseCase "X" "V" "I"


        let (num, rest) = thousands x
        let processingString = rest.ToString("000")

        let numD = processingString.[0] |> baseChar |> fiveHundreds

        let numL = processingString.[1] |> baseChar |> fifties

        let numF = processingString.[2] |> baseChar |> fifhs

        num + numD + numL + numF
