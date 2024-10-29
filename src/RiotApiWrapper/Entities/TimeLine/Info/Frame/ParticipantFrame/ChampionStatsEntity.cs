using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.TimeLine.Info.Frame.ParticipantFrame
{
    public class ChampionStatsEntity
    {
        public int AbilityHaste { get; private set; }
        public int AbilityPower { get; private set; }
        public int Armor { get; private set; }
        public int ArmorPen { get; private set; }
        public int ArmorPenPercent { get; private set; }
        public int AttackDamage { get; private set; }
        public int AttackSpeed { get; private set; }
        public int BonusArmorPenPercent { get; private set; }
        public int BonusMagicPenPercent { get; private set; }
        public int CcReduction { get; private set; }
        public int CooldownReduction { get; private set; }
        public int Health { get; private set; }
        public int HealthMax { get; private set; }
        public int HealthRegen { get; private set; }
        public int Lifesteal { get; private set; }
        public int MagicPen { get; private set; }
        public int MagicPenPercent { get; private set; }
        public int MagicResist { get; private set; }
        public int MovementSpeed { get; private set; }
        public int Omnivamp { get; private set; }
        public int PhysicalVamp { get; private set; }
        public int Power { get; private set; }
        public int PowerMax { get; private set; }
        public int PowerRegen { get; private set; }
        public int SpellVamp { get; private set; }

        [JsonConstructor]
        public ChampionStatsEntity(
            int abilityHaste,
            int abilityPower,
            int armor,
            int armorPen,
            int armorPenPercent,
            int attackDamage,
            int attackSpeed,
            int bonusArmorPenPercent,
            int bonusMagicPenPercent,
            int ccReduction,
            int cooldownReduction,
            int health,
            int healthMax,
            int healthRegen,
            int lifesteal,
            int magicPen,
            int magicPenPercent,
            int magicResist,
            int movementSpeed,
            int omnivamp,
            int physicalVamp,
            int power,
            int powerMax,
            int powerRegen,
            int spellVamp)
        {
            AbilityHaste = abilityHaste;
            AbilityPower = abilityPower;
            Armor = armor;
            ArmorPen = armorPen;
            ArmorPenPercent = armorPenPercent;
            AttackDamage = attackDamage;
            AttackSpeed = attackSpeed;
            BonusArmorPenPercent = bonusArmorPenPercent;
            BonusMagicPenPercent = bonusMagicPenPercent;
            CcReduction = ccReduction;
            CooldownReduction = cooldownReduction;
            Health = health;
            HealthMax = healthMax;
            HealthRegen = healthRegen;
            Lifesteal = lifesteal;
            MagicPen = magicPen;
            MagicPenPercent = magicPenPercent;
            MagicResist = magicResist;
            MovementSpeed = movementSpeed;
            Omnivamp = omnivamp;
            PhysicalVamp = physicalVamp;
            Power = power;
            PowerMax = powerMax;
            PowerRegen = powerRegen;
            SpellVamp = spellVamp;
        }
    }
}
