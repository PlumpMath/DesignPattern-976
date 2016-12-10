using System;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Standard
{
    public class StandardDoor : Door
    {
        public StandardDoor(Room room1, Room room2)
            : base(room1, room2)
        {
        }

        public override void Enter()
        {
            Console.WriteLine("StandardDoor");
        }
    }
}
