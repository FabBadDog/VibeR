namespace VibeR

open Fabulous
open Fabulous.Maui

open type Fabulous.Maui.View

open VibeR.Model

module App =

    let view model =
        Application(
            ContentPage(
                "VibeR",
                VStack(spacing = 16.) {
                    Label("VibeR")
                        .font(size = 32.)
                        .centerTextHorizontal()

                    Label($"Count: %d{model.Count}")
                        .font(size = 24.)
                        .centerTextHorizontal()

                    HStack(spacing = 12.) {
                        Button("-", Decrement)
                            .font(size = 22.)

                        Button("Reset", Reset)

                        Button("+", Increment)
                            .font(size = 22.)
                    }
                    |> _.centerHorizontal()
                }
                |> _.centerVertical()
                |> _.padding(30.)
            )
        )

    let program = Program.stateful init update view
