using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public abstract class MazeGame
    {
        // 迷宫组件的种类的由子类决定
        public Maze CreateMaze()
        {
            Maze maze = this.MakeMze();

            Room room1 = this.MakeRoom(1);
            Room room2 = this.MakeRoom(2);
            Door door = this.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, this.MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, this.MakeWall());
            room1.SetSide(Direction.West, this.MakeWall());

            room2.SetSide(Direction.North, this.MakeWall());
            room2.SetSide(Direction.East, this.MakeWall());
            room2.SetSide(Direction.South, this.MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }

        public abstract Maze MakeMze();

        public abstract Wall MakeWall();

        public abstract Room MakeRoom(int roomNo);

        public abstract Door MakeDoor(Room room1, Room room2);
    }
}
