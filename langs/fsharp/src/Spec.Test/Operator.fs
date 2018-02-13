module Spec.Test.Operator

open System
open Xunit

open Spec.Operator

[<Fact>]
let ``(^^?) (^^!) (!!@) (^^@) works`` () =
  let input = "F# 4.0"

  Assert.Equal(true, input ^^? @"F# [\d\.]+")

  let m = input ^^! @"F# ([\d\.]+)"
  Assert.Equal(1, !!@m)
  Assert.Equal("4.0", m^^@1)

[<Fact>]
let ``(^?) (^!) (!@) (^@) works`` () =
  let input = ".NET Core 2.0 is cool!"

  Assert.Equal(true, input ^? (@".NET Core [\d\.]+", "i"))
  Assert.Equal(".NET Core 2.0 is awesome!", input ^~ ("cool", "awesome", ""))

  let m = input ^! (@".NET Core ([\d\.]+)", "")
  Assert.Equal(1, !@m)
  Assert.Equal("2.0", m^@1)

