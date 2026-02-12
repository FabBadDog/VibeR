# VibeR

An Android app built with F# using .NET MAUI and Fabulous (MVU architecture).

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [.NET MAUI workload](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation)
- Android SDK (API 21+)

## Setup

Install the MAUI workload:

```bash
dotnet workload install maui
```

Restore packages:

```bash
dotnet restore
```

## Build

```bash
dotnet build src/VibeR/VibeR.fsproj -f net8.0-android
```

## Run

On a connected device or emulator:

```bash
dotnet build src/VibeR/VibeR.fsproj -f net8.0-android -t:Run
```

## Project Structure

```
src/VibeR/
  Model.fs          - Domain model, messages, and update logic (MVU)
  App.fs            - UI view definitions using Fabulous DSL
  MauiProgram.fs    - MAUI app builder and entry point
  Platforms/
    Android/
      MainActivity.fs      - Android activity
      MainApplication.fs   - Android application class
      AndroidManifest.xml  - Android manifest
```

## Architecture

The app uses the **Model-View-Update (MVU)** pattern via [Fabulous](https://fabulous.dev/):

- **Model** - Immutable state record
- **Update** - Pure function: `Msg -> Model -> Model`
- **View** - Declarative UI: `Model -> Widget`
