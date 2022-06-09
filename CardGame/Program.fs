﻿let cardValue card =
    let value = card % 13
    if value = 0 then 11
    elif value = 10 || value = 11 || value = 12 then 10
    else value

let hand = [ 0; 25; 31 ]
let sum = List.sumBy(fun card -> cardValue card) hand

printfn "%i" sum