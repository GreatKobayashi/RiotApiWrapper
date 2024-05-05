namespace RiotApiWrapper.Entities
{
    public class AccountEntity
    {
        public AccountEntity(string puuId, string gameName, string tagLine)
        {
            PuuId = puuId;
            GameName = gameName;
            TagLine = tagLine;
        }

        public string PuuId { get; private set; }
        public string GameName { get; private set; }
        public string TagLine { get; private set; }
        public int? ProfileIconId { get; private set; }
        public int? SummonerLevel { get; private set; }
        public string? SummonerId { get; private set; }
        public string? AccountId { get; private set; }
    }
}
