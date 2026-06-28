# MedAvail.Utilities - Private NuGet Package

A simple internal utility library distributed as a private NuGet package. Provides string extensions, date/time helpers, and guard clause utilities.

## Building the Package

```bash
dotnet pack MedAvail.Utilities/MedAvail.Utilities.csproj -c Release -o ./local-feed
```

This produces `MedAvail.Utilities.1.0.0.nupkg` in the `local-feed/` directory.

## Contents

- **StringExtensions** - `ToTitleCase()`, `Truncate()`, `ToSnakeCase()`
- **DateTimeExtensions** - `ToIso8601()`, `IsWeekend()`, `StartOfDay()`, `EndOfDay()`
- **Guard** - `NotNull()`, `NotNullOrEmpty()`, `Positive()`

## Usage

Consumers should add a `nuget.config` pointing to the local feed directory or wherever the .nupkg is hosted.
