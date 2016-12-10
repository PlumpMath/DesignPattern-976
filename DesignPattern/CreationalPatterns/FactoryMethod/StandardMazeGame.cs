using DesignPattern.CreationalPatterns.MapSites.Abstract;
using DesignPattern.CreationalPatterns.MapSites.Standard;

namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public class StandardMazeGame : MazeGame
    {
        public override Maze MakeMze()
        {
            return new StandardMaze();
        }

        public override Wall MakeWall()
        {
            return new StandardWall();
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
