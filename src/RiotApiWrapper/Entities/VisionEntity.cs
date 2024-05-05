namespace RiotApiWrapper.Entities
{
    public class VisionEntity
    {
        public int Score { get; private set; }
        public int WardsPlaced { get; private set; }
        public int ControlWardsPlaced { get; private set; }
        public int ControlWardsBoughtInGame { get; private set; }
    }
}
