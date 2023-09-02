using System.Collections.Generic;

namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(Message message)
        {
            foreach (IObserver obs in observers)
            {
                obs.Update(message);
            }
        }
    }
}
