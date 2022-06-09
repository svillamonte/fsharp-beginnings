// type Person = { FirstName: string; LastName: string }

// let people = [
//   { FirstName = "Albert"; LastName = "Einstein" }
//   { FirstName = "Marie"; LastName = "Curie" }
// ]

// let winners = List.map(fun person -> $"{person.FirstName} {person.LastName}") people
// printfn "%A" winners

let list = [ 1 .. 4 ]

let indexFinder element =
  let found = List.tryFindIndex(fun x -> x = element) list
  match found with
  | Some i -> printfn "%i" i
  | None -> printfn "Hmmm..."

indexFinder 4
indexFinder 5