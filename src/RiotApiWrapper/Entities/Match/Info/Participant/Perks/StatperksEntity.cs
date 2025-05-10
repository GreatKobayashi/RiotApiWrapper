namespace RiotApiWrapper.Entities.Match.Info.Participant.Perks
{
    public class StatperksEntity
    {
        public StatperksEntity(int defense, int flex, int offense)
        {
            Defense = defense;
            Flex = flex;
            Offense = offense;
        }

        /// <summary>
        /// Third row
        /// </summary>
        public int Defense { get; private set; }
        /// <summary>
        /// Second row
        /// </summary>
        public int Flex { get; private set; }
        /// <summary>
        /// First row
        /// </summary>
        public int Offense { get; private set; }
    }
}
