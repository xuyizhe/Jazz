module Spec.Operator

open System.Text.RegularExpressions


//test match
let (^^?) a b = Regex.IsMatch(a, b)
// perform a match and returns match info
let (^^!) a b = Regex.Match(a, b)
// Query the number of matches
let (!!@) (a:Match) = a.Groups.Count - 1
// Access the nth match (1 based, equivalent of $1..$n notation)
let (^^@) (a:Match) (b:int) = a.Groups.[b].Value


let string2opt (s:string) =
  let mutable ret = RegexOptions.ECMAScript
  for c in s do
    match c with
    | 's' -> ret <- ret ||| RegexOptions.Singleline
    | 'm' -> ret <- ret ||| RegexOptions.Multiline
    | 'i' -> ret <- ret ||| RegexOptions.IgnoreCase
    | _ -> ()
  ret

// test match
let (^?) a (b, c) = Regex.IsMatch(a, b, string2opt c)
// perform a match and returns match info
let (^!) a (b, c) = Regex.Match(a, b, string2opt c)
// Query the number of matches
let (!@) (a:Match) = a.Groups.Count - 1
// Access the nth match (1 based, equivalent of $1..$n notation)
let (^@) (a:Match) (b:int) = a.Groups.[b].Value

let (^~) a (b, c:string, d) = Regex.Replace(a, b, c, string2opt d)
