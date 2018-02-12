module Spec.Example

let private square x = x * x

let private isOdd x = x % 2 <> 0

let sumOfSquares xs =
  xs
  |> Seq.filter isOdd
  |> Seq.map square
