namespace DesignPattern.BehaviouralDesignPattern.StrategyDesignPattern
{
    public class KungFu : IMartialArt
    {
        private readonly IKickStrategy kickStrategy;
        private readonly IPunchStrategy punchStrategy;
        public KungFu(IKickStrategy kickStrategy , IPunchStrategy punchStrategy)
        {
            this.kickStrategy = kickStrategy;
            this.punchStrategy = punchStrategy;
        }

        public void Kick()
        { 
            this.kickStrategy.Kick();
        }

        public void Punch()
        { 
            this.punchStrategy.Punch();
        }
    }
}
