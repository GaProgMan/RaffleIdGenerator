# RaffleIdGenerator

An incredibly simple repo which can be used to generate a pseudo-random number for picking out a winner in a raffle.

## Requirements

The following need to be installed before building this repo:

- .NET Core SDK vLTS
- C# 7.1

## Installing From Source

- `cd` into the root of the project
- `dotnet pack --configuration Release src/RaffleIdGenerator.csproj --output ../nuget/`
- repo will be packed into a NuGet package in the `nuget` directory
- `dotnet tool install --global raffleWinnerGen --add-source ./nuget/`

## Uninstalling

- `dotnet tool uninstall -g raffleWinnerGen`