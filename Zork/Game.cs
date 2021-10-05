using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace Zork
{
    class Game
    {
        public World World { get; }
    }

    public static Game Load(string fileName)
    {
        Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(fileName));
        return game;
    }
}
