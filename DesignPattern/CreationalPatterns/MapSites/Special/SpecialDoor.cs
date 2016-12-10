using System;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Special
{
    public class SpecialDoor : Door
    {
        public SpecialDoor(Room room1, Room room2)
            : base(room1, room2)
        {
        }

        public override void Enter()
        {
            Console.WriteLine("SpecialDoor");
        }
    }
}
