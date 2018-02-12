module Spec.Patterns

let mutipleExpr' n =
  match n with
  | 1 | 3 | 5 | 7 -> n + n
  | 2 | 4 | 6 | 8 -> n * n
  | _ -> n



type MushroomColor =
  | Red of int
  | Green
  | Purple

type PowerUp =
  | FireFlower
  | Mushroom of MushroomColor
  | Star of int

let handlePowerUp = function
  | FireFlower -> sprintf "Ouch, that's hot!"
  | Mushroom color ->
    match color with
      | Red count -> sprintf "Please don't step on me...%d" count
      | Green -> sprintf "1UP!!!"
      | Purple -> sprintf "Sorry, about that"
  | Star duration -> sprintf "Let me play some special music for you for %d seconds." duration



let recSearch' lst =
  let rec loop l =
    match l with
      | (1., _, z) :: tail ->
        sprintf "found x=1. and z=%f" z; loop tail
      | (2., _, _) :: tail ->
        sprintf "found x=2."; loop tail
      | _ :: tail -> loop tail
      | [] -> sprintf "done."

  loop lst



let (|Norm|) (a:float, b:float, c:float) =
  sqrt(a*a + b*b + c*c)

let matchNorm v =
  match v with
  | Norm(1.) -> sprintf "Versor found!"
  | Norm(n) -> sprintf "Simple vector with norm %f" n



let (|Vector|Versor|) (a:float, b:float, c:float) =
  match sqrt(a*a + b*b + c*c) with
  | 1. -> Versor
  | _ -> Vector

let VersorOrVector v =
  match v with
  | Versor -> sprintf "Versor found!"
  | Vector -> sprintf "Is a Vector"



let rec isPalindrome (s:string) (fromidx:int) (toidx:int) =
  if s = null then false
  elif toidx - fromidx < 2 then true
  elif s.[fromidx] = s.[(toidx - 1)] then
    isPalindrome s (fromidx + 1) (toidx - 1)
  else false

let (|PALINDROME|_|) (s:string) =
  match isPalindrome s 0 s.Length with
  | true -> Some s
  | false -> None

let matchPalindrome v =
  match v with
  | PALINDROME v -> sprintf "The string %s is palindrome" v
  | "Antonio" -> sprintf "Hello Antonio"
  | _ -> sprintf "Not a special string!"
