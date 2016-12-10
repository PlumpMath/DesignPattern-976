using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DesignPattern.CreationalPatterns.MapSites;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.Builder
{
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();

        public abstract void BuildRoom(int roomNo);

        public abstract void BuildDoor(int room1No, int room2No, Direction direction);

        public abstract Maze GetMaze();

        protected Direction GetReverseDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return Direction.South;
                case Direction.East:
                    return Direction.West;
                case Direction.South:
                    return Direction.North;
                case Direction.West:
                    return Direction.East;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}
