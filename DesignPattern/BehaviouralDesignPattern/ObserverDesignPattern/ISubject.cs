namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public interface ISubject
    {
        //call attach() to add observers to the observer list
        void Attach(IObserver observer);

        //call detach() to remove observers from the observer list
        void Detach(IObserver observer);

        //call notify() to publish all the changes made by the subject
        void Notify(Message message);
    }
}
