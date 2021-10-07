using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }
        public string StartMessage { get; set; }
        public string QuitMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Run()
        {
            Console.WriteLine(StartMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Player.CurrentRoom);

                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Console.WriteLine(Player.CurrentRoom.Description);
                    Player.PreviousRoom = Player.CurrentRoom;
                }

                Console.Write("> ");

                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine(QuitMessage);
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.CurrentRoom.Description);
                        Player.Moves++;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        if ((Player.Move(direction) == false))
                        {
                            Console.WriteLine("The way is shut");
                        }
                        Player.Moves++;
                        break;
                    
                    case Commands.SCORE:
                        Console.WriteLine($"Your score is {Player.Score} after {Player.Moves} move(s).");
                        break;

                    case Commands.REWARD:
                        Player.Score++;
                        Player.Moves++;
                        break;

                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;


    }
}