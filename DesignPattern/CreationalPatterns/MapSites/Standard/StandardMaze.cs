using System.Collections.Generic;
using System.Linq;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Standard
{
    public class StandardMaze : Maze
    {
        private readonly List<Room> _roomList;

        public StandardMaze()
        {
            this._roomList = new List<Room>();
        }

        public override void AddRoom(Room room)
        {
            this._roomList.Add(room);
        }

        public override Room GetRoom(int roomNo)
        {
            return this._roomList.FirstOrDefault(p => p.GetRoomNo() == roomNo);
        }

        public override IEnumerable<Room> GetRooms()
        {
            return this._roomList;
        }
    }
}
