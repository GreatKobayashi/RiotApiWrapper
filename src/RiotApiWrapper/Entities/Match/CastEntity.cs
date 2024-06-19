namespace RiotApiWrapper.Entities.Match
{
    public class CastEntity
    {
        public CastEntity(int spell1, int spell2, int spell3, int spell4, int summonerSpel1, int summonerSpel2)
        {
            Spell1 = spell1;
            Spell2 = spell2;
            Spell3 = spell3;
            Spell4 = spell4;
            SummonerSpel1 = summonerSpel1;
            SummonerSpel2 = summonerSpel2;
        }

        public int Spell1 { get; private set; }
        public int Spell2 { get; private set; }
        public int Spell3 { get; private set; }
        public int Spell4 { get; private set; }
        public int SummonerSpel1 { get; private set; }
        public int SummonerSpel2 { get; private set; }
    }
}
