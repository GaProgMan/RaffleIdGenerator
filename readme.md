# RaffleIdGenerator

An incredibly simple repo which can be used to generate a pseudo-random number for picking out a winner in a raffle.

## Support This Project

If you have found this project helpful, either as a library that you use or as a learning tool, please consider buying me a coffee:

<a href="https://www.buymeacoffee.com/dotnetcoreshow" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important" ></a>

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
