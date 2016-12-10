using DesignPattern.CreationalPatterns.MapSites.Abstract;
using DesignPattern.CreationalPatterns.MapSites.Special;
using DesignPattern.CreationalPatterns.MapSites.Standard;

namespace DesignPattern.CreationalPatterns.AbstractFactory
{
    public class SpecialMazeFactory : MazeFactory
    {
        public override Maze MakeMze()
        {
            return new SpecialMaze();
        }

        public override Wall MakeWall()
        {
            return new SpecialWall();
        }

        public override Room MakeRoom(int roomNo)
        {
            return new StandardRoom(roomNo);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new StandardDoor(room1, room2);
        }
    }
}
