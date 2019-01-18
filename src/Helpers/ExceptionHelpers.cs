using System;

namespace RaffleIdGenerator.Helpers
{
    public static class ExceptionHelpers
    {
        public static ArgumentException RaiseArgumentException(string methodName,
            string message = "Incorrect number of arguments recieved")
        {
            return new ArgumentException($"{methodName} - {message}");
        }
    }
}