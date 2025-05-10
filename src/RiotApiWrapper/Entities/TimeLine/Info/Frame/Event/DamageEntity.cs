namespace RiotApiWrapper.Entities.TimeLine.Info.Frame.Event
{
    public class DamageEntity
    {
        public DamageEntity(
            bool basic,
            int magicDamage,
            string name,
            int participantId,
            int physicalDamage,
            string spellName,
            int spellSlot,
            int trueDamage,
            string type)
        {
            Basic = basic;
            MagicDamage = magicDamage;
            Name = name;
            ParticipantId = participantId;
            PhysicalDamage = physicalDamage;
            SpellName = spellName;
            SpellSlot = spellSlot;
            TrueDamage = trueDamage;
            Type = type;
        }

        /// <summary>
        /// Auto attack
        /// </summary>
        public bool Basic { get; private set; }
        public int MagicDamage { get; private set; }
        public string Name { get; private set; }
        public int ParticipantId { get; private set; }
        public int PhysicalDamage { get; private set; }
        /// <summary>
        /// ""(Empty) -> Damage by item or rune
        /// "burning" -> Red buff
        /// </summary>
        public string SpellName { get; private set; }
        /// <summary>
        /// "-1" -> Damage by item or rune or red buff
        /// "64" -> AA
        /// </summary>
        public int SpellSlot { get; private set; }
        public int TrueDamage { get; private set; }
        /// <summary>
        /// "OTHER" -> By Champion
        /// </summary>
        public string Type { get; private set; }
    }
}
