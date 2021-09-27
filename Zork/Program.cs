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

            //Room previousRoom = null;

            Commands command = new Commands();

            while (true)
            {
                Console.WriteLine(CurrentRoom);

                //if (previousRoom != CurrentRoom)
                //{
                //    Console.WriteLine(CurrentRoom.Description);
                //    previousRoom = CurrentRoom;
                //}

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
            //var roomMap = new Dictionary<string, Room>();
            //foreach (Room room in Rooms)
            //{
            //    roomMap.Add(room.Name, room);
            //}

            Rooms[0, 0].Description = "You are on a rock-strewn trail";
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            Rooms[0, 2].Description = "You are at the top of the Great Canyon on its south wall.";
            
            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";
            Rooms[1, 1].Description = "this is an open field west of a white house, with a boarded front door.";
            Rooms[1, 2].Description = "You are behind the while house. In one corner of the house there is a small window which is slightly ajar.";
            
            Rooms[2, 0].Description = "This is a forest, with trees in all directions aroud you.";
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";


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
