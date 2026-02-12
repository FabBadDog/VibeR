namespace VibeR

open Fabulous

module Model =

    type Msg =
        | Increment
        | Decrement
        | Reset

    type Model = { Count: int }

    let init () = { Count = 0 }

    let update msg model =
        match msg with
        | Increment -> { model with Count = model.Count + 1 }
        | Decrement -> { model with Count = model.Count - 1 }
        | Reset -> init ()
