open System

[<EntryPoint>]
let main argv = 
  printfn "Welcome to the calculator program"

  printfn "Enter first number"
  let first = Console.ReadLine()

  printfn "Enter second number"
  let second = Console.ReadLine()

  printfn "First %s and Second %s" first second

  let sum = (int first) + (int second)
  printfn "The sum is %i" sum
  0