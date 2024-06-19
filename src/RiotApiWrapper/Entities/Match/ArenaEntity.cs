namespace RiotApiWrapper.Entities.Match
{
    public class ArenaEntity
    {
        public ArenaEntity(int augment1, int augment2, int augment3, int augment4, int subteamId, int subteamPlacement)
        {
            Augment1 = augment1;
            Augment2 = augment2;
            Augment3 = augment3;
            Augment4 = augment4;
            SubteamId = subteamId;
            SubteamPlacement = subteamPlacement;
        }

        public int Augment1 { get; private set; }
        public int Augment2 { get; private set; }
        public int Augment3 { get; private set; }
        public int Augment4 { get; private set; }
        public int SubteamId { get; private set; }
        public int SubteamPlacement { get; private set; }
    }
}
