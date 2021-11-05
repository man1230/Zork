using System;
using System.IO;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsGameLoaded { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveWorld(string filename)
        {
            if (!IsGameLoaded)
            {
                throw new InvalidOperationException("No game loaded.");
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidProgramException("Invalid filename");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}
