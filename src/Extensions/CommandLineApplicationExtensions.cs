using System;
using McMaster.Extensions.CommandLineUtils;

namespace RaffleIdGenerator.Helpers
{
    public static class CommandLineApplicationExtensions
    {
        public static int SafeExecuteApp(this CommandLineApplication app, string[] args)
        {
            var returnCode = default(int);
            try
            {
                returnCode = app.Execute(args);
            }
            catch (CommandParsingException)
            {
                app.ShowHelp();
                returnCode = -1;
            }
            return returnCode;
        }

        public static void AddProcess(this CommandLineApplication app)
        {
            app.AddMaxNumberArg();
            app.OnExecute(() =>
            {
                var maxEntrants = PromptHelpers.PromptForInt("How many entrants where there?");
                var rng = new Random(DateTime.Now.Second);

                // Seems like a fair (ish) way to do this.
                var limit = rng.Next(maxEntrants);
                for(var index = 0; index < limit; index++)
                {
                    rng.Next(maxEntrants);
                }
                Console.WriteLine($"And the winner is...{Environment.NewLine}Entrant number {rng.Next(maxEntrants)}");
            });
        }

        private static CommandArgument AddMaxNumberArg(this CommandLineApplication app)
        {
            return app.Argument("MaxNumber", "The maximum number of entrants");
        }

        /// <summary>
        /// Used to generate a "command not found" like message for the instance of the <see cref="CommandLineApplication" />
        /// </summary>
        private static Func<int> AddCommandNotFound(this CommandLineApplication app)
        {
            return () => 
            {
                app.ShowHelp();
                return 1;
            };
        }
    }
}
