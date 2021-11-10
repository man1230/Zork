using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.IO;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }
        public string StartMessage { get; set; }
        public string QuitMessage { get; set; }

        public IOutputService Output { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Run()
        {
            Output.WriteLine(StartMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Output.WriteLine(Player.CurrentRoom);

                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Output.WriteLine(Player.CurrentRoom.Description);
                    Player.PreviousRoom = Player.CurrentRoom;
                }

                Output.Write("> ");

                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Output.WriteLine(QuitMessage);
                        break;

                    case Commands.LOOK:
                        Output.WriteLine(Player.CurrentRoom.Description);
                        Player.Moves++;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if ((Player.Move(direction) == false))
                        {
                            Output.WriteLine("The way is shut");
                        }
                        Player.Moves++;
                        break;

                    case Commands.SCORE:
                        Output.WriteLine($"Your score is {Player.Score} after {Player.Moves} move(s).");
                        break;

                    case Commands.REWARD:
                        Player.Score++;
                        Player.Moves++;
                        break;

                    default:
                        Output.WriteLine("Unknown command");
                        break;
                }
            }
        }

        public static Game Load(string filename, IOutputService output)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Output = output;
            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

    }
}