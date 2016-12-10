using DesignPattern.CreationalPatterns.MapSites.Abstract;
using DesignPattern.CreationalPatterns.MapSites.Standard;

namespace DesignPattern.CreationalPatterns
{
    public class MazeGame
    {
        // 迷宫组件的种类是硬编码的，无法变化
        public virtual Maze CreateMaze()
        {
            Maze maze = new StandardMaze();

            Room room1 = new StandardRoom(1);
            Room room2 = new StandardRoom(2);
            Door door = new StandardDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, new StandardWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, new StandardWall());
            room1.SetSide(Direction.West, new StandardWall());

            room2.SetSide(Direction.North, new StandardWall());
            room2.SetSide(Direction.East, new StandardWall());
            room2.SetSide(Direction.South, new StandardWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
