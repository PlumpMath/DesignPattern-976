using System;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Special
{
    public class SpecialWall : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("SpecialWall");
        }
    }
}
