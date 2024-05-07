namespace RiotApiWrapper.Entities
{
    public class BanEntity
    {
        public BanEntity(int championId, int pickTurn)
        {
            ChampionId = championId;
            PickTurn = pickTurn;
        }

        public int ChampionId { get; private set; }
        public int PickTurn { get; private set; }
    }
}
