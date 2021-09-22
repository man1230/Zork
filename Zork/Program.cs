using System;
using System.Collections.Generic;

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

            Room previousRoom = null;

            while (true)
            {
                Console.WriteLine(CurrentRoom);

                if (previousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }

                Console.Write("> ");

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
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap.Add(room.Name, room);
            }

            roomMap["Rocky Trail"].Description = "You are on a rock-strewn trail";
            roomMap["South of House"].Description = "south house";
            roomMap["Canyon View"].Description = "top canyon";

            roomMap["Forest"].Description = "forest";
            roomMap["West of House"].Description = "west house";
            roomMap["Behind House"].Description = "behind house";

            roomMap["Dense Woods"].Description = "dense woods";
            roomMap["North of House"].Description = "north house";
            roomMap["Clearing"].Description = "clearing";


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
