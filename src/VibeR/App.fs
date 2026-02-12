namespace VibeR

open Fabulous
open Fabulous.Maui
open Microsoft.Maui.Graphics

open type Fabulous.Maui.View

open VibeR.Model

module App =

    let accentColor = Color.FromArgb("#64B5F6")
    let bgColor = Colors.Black
    let textColor = Colors.White

    let view model =
        Application(
            ContentPage(
                (VStack(spacing = 16.) {
                    Label("VibeR")
                        .font(size = 32.)
                        .centerTextHorizontal()
                        .textColor(accentColor)

                    Label($"Count: %d{model.Count}")
                        .font(size = 24.)
                        .centerTextHorizontal()
                        .textColor(textColor)

                    (HStack(spacing = 12.) {
                        Button("-", Decrement)
                            .font(size = 22.)
                            .backgroundColor(accentColor)
                            .textColor(bgColor)
                            .cornerRadius(0)

                        Button("Reset", Reset)
                            .backgroundColor(accentColor)
                            .textColor(bgColor)
                            .cornerRadius(0)

                        Button("+", Increment)
                            .font(size = 22.)
                            .backgroundColor(accentColor)
                            .textColor(bgColor)
                            .cornerRadius(0)
                    })
                        .centerHorizontal()
                })
                    .center()
                    .padding(30.)
            )
                .backgroundColor(bgColor)
        )

    let program = Program.stateful init update view
