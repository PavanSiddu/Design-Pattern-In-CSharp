using System;

namespace DesignPattern.BehaviouralDesignPattern.StrategyDesignPattern
{
    public class Client
    {
        public static void Main()
        {
            KungFu tigerStyle = new KungFu(new FlyingKick() , new OneInchPunch());
            KungFu monkeyStyle = new KungFu(new RotatingKick() , new NormalPunch());
            tigerStyle.Kick();
            tigerStyle.Punch();
            Console.WriteLine("-----------------");
            monkeyStyle.Kick();
            monkeyStyle.Punch();

            Console.ReadLine();
        }
    }
    //Strategy Design Pattern is a behavioral design pattern.
    //It works by abstracting out that part of a class code that is prone to changes into a strategy, which can dynamically be injected at runtime.
}
