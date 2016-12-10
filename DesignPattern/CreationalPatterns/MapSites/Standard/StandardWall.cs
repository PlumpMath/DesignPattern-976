using System;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.MapSites.Standard
{
    public class StandardWall : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("StandardWall");
        }
    }
}
