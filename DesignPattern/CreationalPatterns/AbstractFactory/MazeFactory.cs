using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.AbstractFactory
{
    public abstract class MazeFactory
    {
        public abstract Maze MakeMze();

        public abstract Wall MakeWall();

        public abstract Room MakeRoom(int roomNo);

        public abstract Door MakeDoor(Room room1, Room room2);
    }
}
