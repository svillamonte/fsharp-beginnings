let cardFace (card:int) : string =
  let cardNo: int = card % 13
  if cardNo = 1 then "Ace"
  elif cardNo = 11 then "Jack"
  elif cardNo = 12 then "Queen"
  elif cardNo = 0 then "King"
  else string cardNo

let add2 a = a + 2
let multiply3 a = a * 3

printfn "%s" (cardFace 11)
printfn "%i" ((add2 >> multiply3 >> multiply3) 2)