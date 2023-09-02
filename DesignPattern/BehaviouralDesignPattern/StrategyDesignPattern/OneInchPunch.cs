using System;

namespace DesignPattern.BehaviouralDesignPattern.StrategyDesignPattern
{
    public class OneInchPunch : IPunchStrategy
    {
        public void Punch()
        {
            Console.WriteLine("One Inch Punch");
        }
    }

    public class NormalPunch : IPunchStrategy
    {
        public void Punch()
        {
            Console.WriteLine("Normal Punch");
        }
    }
}
