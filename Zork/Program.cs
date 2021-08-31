using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            Commands command = ToCommand(inputString.Trim());
            Console.WriteLine(command);
        }

        // single line method, compares input to commands by parsing enums. if no match is found than input is UNKNOWN.
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
