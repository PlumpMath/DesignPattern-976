using DesignPattern.CreationalPatterns.MapSites.Abstract;
using DesignPattern.CreationalPatterns.MapSites.Standard;

namespace DesignPattern.CreationalPatterns.Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _maze;

        public override void BuildMaze()
        {
            this._maze = new StandardMaze();
        }

        public override void BuildRoom(int roomNo)
        {
            Room room = new StandardRoom(roomNo);

            room.SetSide(Direction.North, new StandardWall());
            room.SetSide(Direction.East, new StandardWall());
            room.SetSide(Direction.South, new StandardWall());
            room.SetSide(Direction.West, new StandardWall());
        }

        public override void BuildDoor(int room1No, int room2No, Direction direction)
        {
            Room room1 = this._maze.GetRoom(room1No);
            Room room2 = this._maze.GetRoom(room2No);

            Door door = new StandardDoor(room1, room2);

            room1.SetSide(direction, door);
            room1.SetSide(this.GetReverseDirection(direction), door);
        }

        public override Maze GetMaze()
        {
            return this._maze;
        }
    }
}
