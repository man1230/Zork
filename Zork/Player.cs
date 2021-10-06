using Newtonsoft.Json;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        public Room CurrentRoom { get; set; }

        public Room PreviousRoom { get; set; }

        public Player(World world, string startingLocation)
        {
            World = world;

            //for (int row = 0; row < World.Rooms.GetLength(0); row++)
            //{
            //    for (int column = 0; column < World.Rooms.GetLength(1); column++)
            //    {
            //        if (World.Rooms[row, column].Name.Equals(startingLocation, System.StringComparison.OrdinalIgnoreCase))
            //        {
            //            Location = (row, column);
            //            return;
            //        }
                    
            //    }
            //}
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room neighbor);

            if (isValidMove)
            {
                CurrentRoom = neighbor;
            }

            return isValidMove;














            //bool didMove = false;

            //switch (command)
            //{
            //    case Commands.NORTH when Location.Row < World.Rooms.GetLength(0) - 1:
            //        Location.Row++;
            //        didMove = true;
            //        break;
            //    case Commands.SOUTH when Location.Row > 0:
            //        Location.Row--;
            //        didMove = true;
            //        break;
            //    case Commands.EAST when Location.Column < World.Rooms.GetLength(1) - 1:
            //        Location.Column++;
            //        didMove = true;
            //        break;
            //    case Commands.WEST when Location.Column > 0:
            //        Location.Column--;
            //        didMove = true;
            //        break;
            //}
        }
    }
}
