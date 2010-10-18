module Scrabble.Driver

open Scrabble.Core.Squares
open Scrabble.Core.Types
open Scrabble.Core.Config


(*

This will serve as a dumping ground for random tests for now, 
but eventually we can invoke our GUI here, whether it's WPF or something else.

*)


let w = Tile('W')
printfn "The letter is %c with a score of %i" w.Letter w.Score

let bag = Bag()
bag.PrintAll()
bag.Take(90)
printfn "I took 90 tiles from the bag."
bag.PrintRemaining()
bag.Take(6)
printfn "I took 6 tiles from the bag."
bag.PrintRemaining()
//let's make sure we only get two and don't get an out of range ex ;)
let lastTiles = bag.Take(7)
printfn "I wanted to take 6 tiles from the bag, but I only got %i." lastTiles.Length
printfn "The last tiles I took were:"
lastTiles |> Seq.iter (fun t -> t.Print())
printfn "I want to make sure the bag is really empty. This next line should print nothing."
bag.PrintRemaining()

//this line will throw
//bag.Take()
