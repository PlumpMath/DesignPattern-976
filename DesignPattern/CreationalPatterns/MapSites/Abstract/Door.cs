using System;

namespace DesignPattern.CreationalPatterns.MapSites.Abstract
{
    public abstract class Door : MapSite
    {
        private Room _room1;

        private Room _room2;

        protected Door(Room room1, Room room2)
        {
            this._room1 = room1;
            this._room2 = room2;
        }
    }
}
