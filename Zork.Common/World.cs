using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Zork
{
    public class World
    {
        public Room[] Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        [OnDeserialized]
        public void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        [JsonProperty]

        public string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;
    }
}
