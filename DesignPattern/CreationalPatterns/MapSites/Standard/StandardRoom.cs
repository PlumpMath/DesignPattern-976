using System;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Standard
{
    public class StandardRoom : Room
    {
        public StandardRoom(int roomNo) : base(roomNo)
        {
        }

        public override void Enter()
        {
            Console.WriteLine("StandardRoom");
        }
    }
}
