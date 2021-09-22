using System;

namespace Zork
{
    class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            InitializeRoomDescriptions();

            Console.WriteLine("Welcome to Zork!");

            while (true)
            {
                Console.Write($"{CurrentRoom.Name}\n> ");
                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if ((Move(command) == false))
                        {
                            Console.WriteLine("The way is shut");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when LocationRow < Rooms.GetLength(0) - 1:
                    LocationRow++;
                    didMove = true;
                    break;
                case Commands.SOUTH when LocationRow > 0:
                    LocationRow--;
                    didMove = true;
                    break;
                case Commands.EAST when LocationColumn < Rooms.GetLength(1) - 1:
                    LocationColumn++;
                    didMove = true;
                    break;
                case Commands.WEST when LocationColumn > 0:
                    LocationColumn--;
                    didMove = true;
                    break;
            }
            return didMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static void InitializeRoomDescriptions()
        {
            Rooms[0, 0].Description = "You are on a rock-strewn trail";
            Rooms[0, 1].Description = "south house";
            Rooms[0, 2].Description = "top canyon";

            Rooms[1, 0].Description = "forest";
            Rooms[1, 1].Description = "west house";
            Rooms[1, 2].Description = "behind house";

            Rooms[2, 0].Description = "dense woods";
            Rooms[2, 1].Description = "north house";
            Rooms[2, 2].Description = "clearing";


        }

        private static readonly Room[,] Rooms =
        {
            { new Room("Rocky Trail"),    new Room("South of House"),   new Room("Canyon View") },
            { new Room("Forest"),         new Room("West of House"),    new Room("Behind House") },
            { new Room("Dense Woods"),    new Room("North of House"),   new Room("Clearing") }
        };

        private static int LocationRow = 1;
        private static int LocationColumn = 1;
    }
}
