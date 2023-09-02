namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public interface IObserver
    {
        //call update() to inform all the observers about the chnages in the subject
        void Update(Message m);
    }
}
