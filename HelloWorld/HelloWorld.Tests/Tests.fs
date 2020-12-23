module Tests

open Xunit
open FsUnit.Xunit

[<Fact>]
let ``5 + 4 = 9`` () =
    let result = FancyAlgorithm.magicMath 5 4
    result |> should equal 9
