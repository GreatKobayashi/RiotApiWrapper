using RiotApiWrapper.Entities;

namespace RiotApiWrapper.Logics
{
    public static class CDragonUtility
    {
        public static ChampionDetailEntity GetChampionDetail(ChampionEntity champion)
        {
            return GetChampionDetail(champion.Id);
        }

        public static ChampionDetailEntity GetChampionDetail(int championId)
        {
            // TODO
            return new ChampionDetailEntity(0, "", 0);
        }
    }
}
