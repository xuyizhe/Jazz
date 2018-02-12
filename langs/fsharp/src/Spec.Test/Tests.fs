module Spec.Test.Basic

open System
open Xunit

open Spec.Example

[<Fact>]
let ``My test`` () =
  Assert.True(true)

[<Fact>]
let ``SquaresOfOdds works`` () =
  let expected = [1; 9; 25; 49; 81]
  let actual = sumOfSquares [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
  Assert.Equal(expected, actual)
