namespace RiotApiWrapper.Entities.Match.Info.Participant.Perks
{
    public class SelectionEntity
    {
        public SelectionEntity(int perk, int var1, int var2, int var3)
        {
            Perk = perk;
            Var1 = var1;
            Var2 = var2;
            Var3 = var3;
        }

        /// <summary>
        /// Id
        /// </summary>
        public int Perk { get; private set; }
        /// <summary>
        /// For the end of game stats e.g. First Strike damage and gold
        /// </summary>
        public int Var1 { get; private set; }
        /// <summary>
        /// For the end of game stats e.g. First Strike damage and gold
        /// </summary>
        public int Var2 { get; private set; }
        /// <summary>
        /// For the end of game stats e.g. First Strike damage and gold
        /// </summary>
        public int Var3 { get; private set; }
    }
}
