﻿using System;

namespace Zork
{
    class Room
    {
        public string Name { get; }

        public string Description { get; }

        public Room(string name, string description = null)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
