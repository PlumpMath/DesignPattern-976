using System;
using System.Collections.Generic;
using System.Linq;
using DesignPattern.CreationalPatterns.AbstractFactory;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private readonly CloneableMaze _maze;

        private readonly CloneableWall _wall;

        private readonly CloneableRoom _room;

        private readonly CloneableDoor _door;

        public MazePrototypeFactory(CloneableMaze maze, CloneableWall wall, CloneableRoom room, CloneableDoor door)
        {
            this._maze = maze;
            this._wall = wall;
            this._room = room;
            this._door = door;
        }

        public override Maze MakeMze()
        {
            return this._maze.Clone();
        }

        public override Wall MakeWall()
        {
            return this._wall.Clone();
        }

        public override Room MakeRoom(int roomNo)
        {
            return this._room.Clone();
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return this._door.Clone();
        }
    }

    public interface ICloneable<out T> where T : class
    {
        T Clone();
    }

    public class CloneableMaze : Maze, ICloneable<Maze>
    {
        private List<Room> _rooms; 

        public Maze Clone()
        {
            return this.MemberwiseClone() as Maze;
        }

        public override void AddRoom(Room room)
        {
            this._rooms.Add(room);
        }

        public override Room GetRoom(int roomNo)
        {
            return this._rooms.FirstOrDefault(p => p.GetRoomNo() == roomNo);
        }

        public override IEnumerable<Room> GetRooms()
        {
            return this._rooms;
        }
    }

    public class CloneableWall : Wall, ICloneable<Wall>
    {
        public Wall Clone()
        {
            return this.MemberwiseClone() as Wall;
        }

        public override void Enter()
        {
        }
    }

    public class CloneableRoom : Room, ICloneable<Room>
    {
        public CloneableRoom(int roomNo) : base(roomNo)
        {

        }

        public Room Clone()
        {
            return this.MemberwiseClone() as Room;
        }

        public override void Enter()
        {
        }
    }

    public class CloneableDoor : Door, ICloneable<Door>
    {
        public CloneableDoor(Room room1, Room room2) : base(room1, room2)
        {
        }

        public Door Clone()
        {
            return this.MemberwiseClone() as Door;
        }

        public override void Enter()
        {
        }
    }
}
