using McMaster.Extensions.CommandLineUtils;

namespace RaffleIdGenerator.Helpers
{
    public static class ApplicationHelpers
    {
        public static CommandLineApplication GenerateApplication(string name, string description)
        {
            var app = new CommandLineApplication
            {
                Name = name,
                Description = description,
            };

            app.HelpOption(inherited: true);

            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 1;
            });

            app.AddProcess();

            return app;
        }
    }
}