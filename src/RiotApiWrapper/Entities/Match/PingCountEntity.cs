namespace RiotApiWrapper.Entities.Match
{
    public class PingCountEntity
    {
        public PingCountEntity(int allIn, int assistMe, int basic, int command, int danger, int enemyMissing, int enemyVision, int getBack, int hold, int needVision, int onMyWay, int push, int visionCleared)
        {
            AllIn = allIn;
            AssistMe = assistMe;
            Basic = basic;
            Command = command;
            Danger = danger;
            EnemyMissing = enemyMissing;
            EnemyVision = enemyVision;
            GetBack = getBack;
            Hold = hold;
            NeedVision = needVision;
            OnMyWay = onMyWay;
            Push = push;
            VisionCleared = visionCleared;
        }

        public int AllIn { get; private set; }
        public int AssistMe { get; private set; }
        public int Basic { get; private set; }
        public int Command { get; private set; }
        public int Danger { get; private set; }
        public int EnemyMissing { get; private set; }
        public int EnemyVision { get; private set; }
        public int GetBack { get; private set; }
        public int Hold { get; private set; }
        public int NeedVision { get; private set; }
        public int OnMyWay { get; private set; }
        public int Push { get; private set; }
        public int VisionCleared { get; private set; }
    }
}
