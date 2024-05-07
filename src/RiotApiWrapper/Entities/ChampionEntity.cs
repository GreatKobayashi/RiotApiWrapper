namespace RiotApiWrapper.Entities
{
    public class ChampionEntity
    {
        public ChampionEntity(int id, string name, int transform)
        {
            Id = id;
            Name = name;
            Transform = transform;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Transform { get; private set; }
    }
}
