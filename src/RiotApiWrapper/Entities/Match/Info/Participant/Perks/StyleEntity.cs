using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match.Info.Participant.Perks
{
    public class StyleEntity
    {
        public List<SelectionEntity> Selections { get; private set; }

        /// <summary>
        /// Rune Path
        /// </summary>
        public int Style { get; private set; }

        [JsonConstructor]
        public StyleEntity(List<SelectionEntity> selections, int style)
        {
            Selections = selections;
            Style = style;
        }
    }
}
