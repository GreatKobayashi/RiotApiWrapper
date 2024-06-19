namespace RiotApiWrapper.Entities.Match.MatchTimeLine
{
    public class CurrentChampionStatEntity
    {
        public CurrentChampionStatEntity(int perticipantId, CurrentStatusEntity champion, CurrentDamageEntity damage, CurrentGoldEntity gold)
        {
            PerticipantId = perticipantId;
            Champion = champion;
            Damage = damage;
            Gold = gold;
        }

        public int PerticipantId { get; private set; }

        public CurrentStatusEntity Champion { get; private set; }
        public CurrentDamageEntity Damage { get; private set; }
        public CurrentGoldEntity Gold { get; private set; }
    }
}
