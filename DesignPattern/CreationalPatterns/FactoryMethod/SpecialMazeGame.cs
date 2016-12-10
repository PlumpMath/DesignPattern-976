using DesignPattern.CreationalPatterns.MapSites.Abstract;
using DesignPattern.CreationalPatterns.MapSites.Special;

namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public class SpecialMazeGame : MazeGame
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
            return new SpecialRoom(roomNo);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new SpecialDoor(room1, room2);
        }
    }
}
