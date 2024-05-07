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
    }
}
