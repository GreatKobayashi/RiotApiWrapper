using RiotApiWrapper.Entities.Match.Info.Participant.Perks;

namespace RiotApiWrapper.Entities.Match.Info.Participant
{
    public class PerksEntity
    {
        public PerksEntity(StatperksEntity statperks, List<StyleEntity> styles)
        {
            Statperks = statperks;
            Styles = styles;
        }

        public StatperksEntity Statperks { get; private set; }
        /// <summary>
        /// Index 0 : Primary path
        /// Index 1 : Sub Path
        /// </summary>
        public List<StyleEntity> Styles { get; private set; }
    }
}
