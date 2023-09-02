using System;

namespace DesignPattern.BehaviouralDesignPattern.StrategyDesignPattern
{
    public class FlyingKick : IKickStrategy
    {
        public void Kick()
        {
            Console.WriteLine("Flying Kick..");
        }
    }

    public class RotatingKick : IKickStrategy
    {
        public void Kick()
        {
            Console.WriteLine("Rotating Kick..");
        }
    }

    public class NormalKick : IKickStrategy
    {
        public void Kick()
        {
            Console.WriteLine("Normal Kick..");
        }
    }
}
