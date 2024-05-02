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

        public string PuuId { get; set; }
        public string GameName { get; set; }
        public string TagLine { get; set; }

    }
}
