using System;
using McMaster.Extensions.CommandLineUtils;

namespace RaffleIdGenerator.Helpers
{

    public static class PromptHelpers
    {
        /// <summary>
        /// Used to prompt the user for an integer and verify that they user has
        /// entered a valid (i.e. not less than the default) value integer
        /// </summary>
        /// <param name="message">A prompt message to display to the user</param>
        /// <param name="defaultValue">
        /// [OPTIONAL]
        /// The default value to use if the user does not supply a value. It also
        /// acts as a lower limit check
        /// </param>
        /// /// <remarks>Raises an <see cref="ArgumentException"/> if a value is not valid</remarks>
        public static int PromptForInt(string message, int defaultValue = 0)
        {
            var userInput = Prompt.GetInt(message, defaultValue,
                promptColor: ConsoleColor.White,
                promptBgColor: ConsoleColor.DarkBlue);

            if (userInput < defaultValue)
            {
                throw ExceptionHelpers.RaiseArgumentException(nameof(PromptForInt),
                    $"User input ({userInput}) was less than the default value ({defaultValue})");
            }

            return userInput;
        }
        /// <summary>
        /// Used to prompt the user for a boolean value
        /// </summary>
        /// <param name="message">A prompt message to display to the user</param>
        public static bool PromptForBool(string message)
        {
            return Prompt.GetYesNo(message,
                defaultAnswer: default(bool),
                promptColor: ConsoleColor.White,
                promptBgColor: ConsoleColor.DarkBlue);
        }

    }
}