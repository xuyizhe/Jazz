module Spec.Test.Patterns

open System
open Xunit

open Spec.Patterns

[<Fact>]
let ``mutipleExpr' works`` () =
  Assert.Equal(6, mutipleExpr' 3)
  Assert.Equal(64, mutipleExpr' 8)
  Assert.Equal(11, mutipleExpr' 11)

[<Fact>]
let ``fizzbuzz works`` () =
  Assert.Equal("fizzbuzz", fizzbuzz 30)
  Assert.Equal("buzz", fizzbuzz 20)
  Assert.Equal("19", fizzbuzz 19)
  Assert.Equal("fizz", fizzbuzz 18)

[<Fact>]
let ``recSearch' works`` () =
  Assert.Equal("done.", recSearch' [
    (1., 2., 0.)
    (2., 1., 1.)
    (3., 0., 1.)
    ])

[<Fact>]
let ``matchNorm works`` () =
  Assert.Equal("Versor found!", matchNorm (1., 0., 0.))
  Assert.Equal("Simple vector with norm 2.000000", matchNorm (2., 0., 0.))

[<Fact>]
let ``VersorOrVector works`` () =
  Assert.Equal("Versor found!", VersorOrVector (1., 0., 0.))
  Assert.Equal("Is a Vector", VersorOrVector (2., 0., 0.))

[<Fact>]
let ``handlePowerUp works`` () =
  Assert.Equal("Ouch, that's hot!", handlePowerUp FireFlower)
  Assert.Equal("Please don't step on me...4", handlePowerUp (Mushroom <| Red 4))
  Assert.Equal("Let me play some special music for you for 4 seconds.", handlePowerUp (Star 4))

[<Fact>]
let ``matchPalindrome works`` () =
  Assert.Equal("The string aba is palindrome", matchPalindrome "aba")
  Assert.Equal("Not a special string!", matchPalindrome "foo")
  Assert.Equal("Hello Antonio", matchPalindrome "Antonio")
