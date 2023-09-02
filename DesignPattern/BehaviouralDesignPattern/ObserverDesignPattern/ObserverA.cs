using System;


//individual child observers implements the parent observer class
namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public class ObserverA : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("observerA: " + m.GetMessage());
        }
    }

    public class ObserverB : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("observerB: " + m.GetMessage());
        }
    }

    public class ObserverC : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("observerC: " + m.GetMessage());
        }
    }
}
