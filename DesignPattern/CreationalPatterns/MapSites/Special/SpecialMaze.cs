using System.Collections.Generic;
using System.Linq;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Special
{
    public class SpecialMaze : Maze
    {
        private readonly LinkedList<Room> _roomList;

        public SpecialMaze()
        {
            this._roomList = new LinkedList<Room>();
        }

        public override void AddRoom(Room room)
        {
            this._roomList.AddLast(room);
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
