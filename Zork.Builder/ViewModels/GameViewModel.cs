using System;
using System.ComponentModel;

namespace Zork.Builder
{
    internal class GameViewModel
    {
        public BindingList<Room> Rooms { get; set; }

        public Game game
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

        private Game _game;
    }
}
