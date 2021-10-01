using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        private static readonly Dictionary<string, Room> RoomMap;
        static Program()
        {
            RoomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                RoomMap[room.Name] = room;
            }
        }

        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            const string defaultRoomsFileName = "Rooms.txt";
            string roomsFileName = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultRoomsFileName);
            InitializeRoomDescriptions(defaultRoomsFileName);

            Room previousRoom = null;

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
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
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    didMove = true;
                    break;
                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    didMove = true;
                    break;
                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    didMove = true;
                    break;
                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    didMove = true;
                    break;
            }
            return didMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static void InitializeRoomDescriptions(string roomFileName)
        {
            const string delimiter = "##";
            const int expectedFieldCount = 2;

            string[] lines = File.ReadAllLines(roomFileName);
            foreach (string line in lines)
            {

                string[] fields = line.Split(delimiter);
                if (fields.Length != expectedFieldCount)
                {
                    throw new Exception("Invalid Record.");
                }
                //Assert.IsTrue(fields.Length == expectedFieldCount, "Invalid record.");

                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);

                RoomMap[name].Description = description;
            }
        }

        private static readonly Room[,] Rooms =
        {
            { new Room("Rocky Trail"),    new Room("South of House"),   new Room("Canyon View") },
            { new Room("Forest"),         new Room("West of House"),    new Room("Behind House") },
            { new Room("Dense Woods"),    new Room("North of House"),   new Room("Clearing") }
        };

        private enum Fields
        {
            Name = 0,
            Description = 1
        }

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }

        private static (int Row, int Column) Location = (1, 1);
    }
}
