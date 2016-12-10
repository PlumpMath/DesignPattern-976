using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CreationalPatterns.MapSites.Abstract
{
    public abstract class Maze
    {
        public abstract void AddRoom(Room room);

        public abstract Room GetRoom(int roomNo);

        public abstract IEnumerable<Room> GetRooms();

    }
}
