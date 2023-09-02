namespace DesignPattern.BehaviouralDesignPattern.MediatorDesignPattern
{
    public interface IMediator
    {
        void Notify(Component sender, string message);

        void Register(Component component);
    }
}
