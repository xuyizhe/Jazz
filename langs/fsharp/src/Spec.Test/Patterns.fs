module Spec.Test.Patterns

open System
open Xunit

open Spec.Patterns

[<Fact>]
let ``mutipleExpr' works`` () =
  Assert.Equal(6, mutipleExpr' 3)
  Assert.Equal(64, mutipleExpr' 8)
  Assert.Equal(11, mutipleExpr' 11)
