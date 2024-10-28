using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match.Info.Team
{
    public class BanEntity
    {
        public int ChampionId { get; private set; }
        public int PickTurn { get; private set; }

        [JsonConstructor]
        public BanEntity(int championId, int pickTurn)
        {
            ChampionId = championId;
            PickTurn = pickTurn;
        }
    }
}
