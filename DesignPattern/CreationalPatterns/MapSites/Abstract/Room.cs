namespace DesignPattern.CreationalPatterns.MapSites.Abstract
{
    public abstract class Room : MapSite
    {
        private readonly int _roomNo;

        private readonly MapSite[] _sides;

        protected Room(int roomNo)
        {
            this._roomNo = roomNo;
            this._sides = new MapSite[4];
        }

        public int GetRoomNo()
        {
            return this._roomNo;
        }

        public MapSite GetSide(Direction direction)
        {
            return this._sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            this._sides[(int) direction] = mapSite;
        }
    }
}
