module Scrabble.Core.Squares

[<AbstractClass>]
type Square(letterMult:int, wordMult:int) = 
    let mutable used = false // Indicates whether or not the multipliers have been applied before. Might remove this in favor of a better way of representing this. Not sure yet.
    let mutable tile = null
    member this.LetterMultiplier with get() = letterMult
    member this.WordMultiplier with get() = wordMult
    member this.Used with get() = used and set v = used <- v
    member this.Tile with get() = tile and set t = tile <- t
    member this.IsEmpty with get() = tile = null

type NormalSquare() = 
    inherit Square(1, 1)

type DoubleLetterSquare() =
    inherit Square(2, 1)

type TripleLetterSquare() =
    inherit Square(3, 1)

type DoubleWordSquare() =
    inherit Square(1, 2)

type StartSquare() =
    inherit DoubleWordSquare()

type TripleWordSquare() =
    inherit Square(1, 3)