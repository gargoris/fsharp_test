module TestsRomanNumerals

open RomanNumerals.Library.Numerals
open Expecto

[<Tests>]
let tests =
    testList
        "Test roman nummerals"
        [ testCase "Testing number 1"
          <| fun _ ->
              let expected = "I"
              let actual = GetRomanNumeral 1

              Expect.equal actual expected "Number 1 failed"
          testCase "Testing number 1000"
          <| fun _ ->
              let expected = "M"
              let actual = GetRomanNumeral 1000
              Expect.equal actual expected "Number 1000 failed"
          testCase "Testing number 1999"
          <| fun _ ->
              let expected = "MCMXCIX"
              let actual = GetRomanNumeral 1999
              Expect.equal actual expected "Number 1999 failed"

          testCase "Testing number 1456"
          <| fun _ ->
              let expected = "MCDLVI"
              let actual = GetRomanNumeral 1456
              Expect.equal actual expected "Number 1456 failed"

          ]
