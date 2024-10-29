using RiotApiWrapper.Entities.Common;
using RiotApiWrapper.Entities.TimeLine.Info.Frame.Event;
using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.TimeLine.Info.Frame
{
    public class EventEntity
    {
        public int Timestamp { get; private set; }
        public string Type { get; private set; }


        // Options ↓↓

        public int? ParticipantId { get; private set; }

        /// <summary>
        /// Only for Game Start or End.
        /// UnixMilliseconds
        /// </summary>
        public long? RealTimestamp { get; private set; }

        /// <summary>
        /// Only for Skill Level up event.
        /// "NORMAL" or "EVOLVE"(Kai'sa, Kha'Zix, Viktor)
        /// </summary>
        public string LevelUpType { get; private set; }
        /// <summary>
        /// Only for Skill Level up event.
        /// </summary>
        public int? SkillSlot { get; private set; }

        public int? ItemId { get; private set; }
        /// <summary>
        /// ItemId After Undo Item purchace or synthesis
        /// </summary>
        public int? AfterId { get; private set; }
        /// <summary>
        /// ItemId Before Undo Item purchace or synthesis
        /// </summary>
        public int? BeforeId { get; private set; }
        /// <summary>
        /// Comebacked gold On Undo Item purchace or synthesis
        /// </summary>
        public int? GoldGain { get; private set; }

        public List<int> AssistingParticipantIds { get; private set; }
        public int? Bounty { get; private set; }
        public int? KillStreakLength { get; private set; }
        public int? KillerId { get; private set; }
        public PositionEntity Position { get; private set; }
        public int? ShutdownBounty { get; private set; }
        public List<DamageEntity> VictimDamageDealt { get; private set; }
        public List<DamageEntity> VictimDamageReceived { get; private set; }
        public int? VictimId { get; private set; }

        /// <summary>
        /// First blood, Multi kill, Ace ..
        /// </summary>
        public string KillType { get; private set; }

        public int? CreatorId { get; private set; }
        /// <summary>
        /// "UNDEFINED" -> Some stuff created by Champion skills e.g. Teemo's mushroom, Shaco's Box ..
        /// </summary>
        public string WardType { get; private set; }

        public int? Level { get; private set; }

        public int? KillerTeamId { get; private set; }

        /// <summary>
        /// Type of Drake.
        /// </summary>
        public string MonsterSubType { get; private set; }
        /// <summary>
        /// "HORDE" -> Void Grub 
        /// </summary>
        public string MonsterType { get; private set; }

        /// <summary>
        /// Only for Objective bounty
        /// </summary>
        public int? ActualStartTime { get; private set; }

        public string BuildingType { get; private set; }
        public string LaneType { get; private set; }
        public string TowerType { get; private set; }

        /// <summary>
        /// Only for Game end
        /// </summary>
        public int? WinningTeam { get; private set; }

        [JsonConstructor]
        public EventEntity(
            int timestamp,
            string type,
            int? participantId,
            long? realTimestamp,
            string levelUpType,
            int? skillSlot,
            int? itemId,
            int? afterId,
            int? beforeId,
            int? goldGain,
            List<int> assistingParticipantIds,
            int? bounty,
            int? killStreakLength,
            int? killerId,
            PositionEntity position,
            int? shutdownBounty,
            List<DamageEntity> victimDamageDealt,
            List<DamageEntity> victimDamageReceived,
            int? victimId,
            string killType,
            int? creatorId,
            string wardType,
            int? level,
            int? killerTeamId,
            string monsterSubType,
            string monsterType,
            int? actualStartTime,
            string buildingType,
            string laneType,
            string towerType,
            int? winningTeam)
        {
            Timestamp = timestamp;
            Type = type;
            ParticipantId = participantId;
            RealTimestamp = realTimestamp;
            LevelUpType = levelUpType;
            SkillSlot = skillSlot;
            ItemId = itemId;
            AfterId = afterId;
            BeforeId = beforeId;
            GoldGain = goldGain;
            AssistingParticipantIds = assistingParticipantIds;
            Bounty = bounty;
            KillStreakLength = killStreakLength;
            KillerId = killerId;
            Position = position;
            ShutdownBounty = shutdownBounty;
            VictimDamageDealt = victimDamageDealt;
            VictimDamageReceived = victimDamageReceived;
            VictimId = victimId;
            KillType = killType;
            CreatorId = creatorId;
            WardType = wardType;
            Level = level;
            KillerTeamId = killerTeamId;
            MonsterSubType = monsterSubType;
            MonsterType = monsterType;
            ActualStartTime = actualStartTime;
            BuildingType = buildingType;
            LaneType = laneType;
            TowerType = towerType;
            WinningTeam = winningTeam;
        }
    }
}
