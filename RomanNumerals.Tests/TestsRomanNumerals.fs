module TestsRomanNumerals

open System
open Xunit
open RomanNumerals.Library.Numerals

[<Fact>]
let ``Test numer one`` () =
    let expected = "I"

    let actual = GetRomanNumeral 1
    Assert.Equal(expected, actual)
