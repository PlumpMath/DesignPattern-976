using System;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Special
{
    public class SpecialRoom : Room
    {
        public SpecialRoom(int roomNo)
            : base(roomNo)
        {
        }

        public override void Enter()
        {
            Console.WriteLine("SpecialRoom");
        }
    }
}
