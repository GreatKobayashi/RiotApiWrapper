using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match.MatchTimeLine
{
    public class CurrentStatusEntity
    {
        [JsonInclude]
        public int AbilityHaste { get; private set; }
        [JsonInclude]
        public int AbilityPower { get; private set; }
        [JsonInclude]
        public int Armor { get; private set; }
        [JsonInclude]
        public int ArmorPen { get; private set; }
        [JsonInclude]
        public int ArmorPenPercent { get; private set; }
        [JsonInclude]
        public int AttackDamage { get; private set; }
        [JsonInclude]
        public int AttackSpeed { get; private set; }
        [JsonInclude]
        public int BonusArmorPenPercent { get; private set; }
        [JsonInclude]
        public int BonusMagicPenPercent { get; private set; }
        [JsonInclude]
        public int CcReduction { get; private set; }
        [JsonInclude]
        public int CooldownReduction { get; private set; }
        [JsonInclude]
        public int Health { get; private set; }
        [JsonInclude]
        public int HealthMax { get; private set; }
        [JsonInclude]
        public int HealthRegen { get; private set; }
        [JsonInclude]
        public int Lifesteal { get; private set; }
        [JsonInclude]
        public int MagicPen { get; private set; }
        [JsonInclude]
        public int MagicPenPercent { get; private set; }
        [JsonInclude]
        public int MagicResist { get; private set; }
        [JsonInclude]
        public int MovementSpeed { get; private set; }
        [JsonInclude]
        public int Omnivamp { get; private set; }
        [JsonInclude]
        public int PhysicalVamp { get; private set; }
        [JsonInclude]
        public int Power { get; private set; }
        [JsonInclude]
        public int PowerMax { get; private set; }
        [JsonInclude]
        public int PowerRegen { get; private set; }
        [JsonInclude]
        public int SpellVamp { get; private set; }

        [JsonIgnore]
        public int Level { get; internal set; }
        [JsonIgnore]
        public int Exp { get; internal set; }
    }
}
