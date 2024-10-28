using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match.MatchTimeLine
{
    public class CurrentDamageEntity
    {
        [JsonInclude]
        public int MagicDamageDone { get; private set; }
        [JsonInclude]
        public int MagicDamageDoneToChampions { get; private set; }
        [JsonInclude]
        public int MagicDamageTaken { get; private set; }
        [JsonInclude]
        public int PhysicalDamageDone { get; private set; }
        [JsonInclude]
        public int PhysicalDamageDoneToChampions { get; private set; }
        [JsonInclude]
        public int PhysicalDamageTaken { get; private set; }
        [JsonInclude]
        public int TotalDamageDone { get; private set; }
        [JsonInclude]
        public int TotalDamageDoneToChampions { get; private set; }
        [JsonInclude]
        public int TotalDamageTaken { get; private set; }
        [JsonInclude]
        public int TrueDamageDone { get; private set; }
        [JsonInclude]
        public int TrueDamageDoneToChampions { get; private set; }
        [JsonInclude]
        public int TrueDamageTaken { get; private set; }

        [JsonIgnore]
        public TimeSpan TimeCCDone { get; internal set; }
    }
}
