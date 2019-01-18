using System;
using McMaster.Extensions.CommandLineUtils;
using RaffleIdGenerator.Helpers;

namespace RaffleIdGenerator
{
    [Command(Name = "raffleWinner",
    Description = "Prompts for the maximum number of entrants, then picks a random winner",
    FullName = "Raffle ID Generator")]
    class Program
    {
        static int Main(string[] args)
        {
            return ApplicationHelpers
                .GenerateApplication("raffleWinner",
                    "Prompts for the maximum number of entrants, then picks a random winner")
                .SafeExecuteApp(args);
        }
    }
}
