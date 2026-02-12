namespace VibeR

module Model =

    type Msg =
        | Increment
        | Decrement
        | Reset

    type Model = { Count: int }

    let initModel = { Count = 0 }

    let init () = initModel

    let update msg model =
        match msg with
        | Increment -> { model with Count = model.Count + 1 }
        | Decrement -> { model with Count = model.Count - 1 }
        | Reset -> initModel
