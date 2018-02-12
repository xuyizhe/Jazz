module Spec.Patterns

let mutipleExpr' n =
  match n with
  | 1 | 3 | 5 | 7 -> n + n
  | 2 | 4 | 6 | 8 -> n * n
  | _ -> n
