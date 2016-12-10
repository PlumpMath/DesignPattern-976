using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern.CreationalPatterns.AbstractFactory;
using DesignPattern.CreationalPatterns.MapSites.Abstract;
using DesignPattern.CreationalPatterns.MapSites.Standard;

namespace DesignPattern.CreationalPatterns.Singleton
{
    public class SingletonMazeFactory : MazeFactory
    {
        private static readonly SingletonMazeFactory Instance = new SingletonMazeFactory();


        private SingletonMazeFactory() { }

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
