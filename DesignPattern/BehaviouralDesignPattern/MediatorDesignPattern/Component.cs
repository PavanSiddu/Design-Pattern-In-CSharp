namespace DesignPattern.BehaviouralDesignPattern.MediatorDesignPattern
{
    public abstract class Component
    {
        private string name;
        protected IMediator mediator;

        public Component(string name, IMediator m)
        {
            this.mediator = m;
            this.name = name;
        }

        public abstract void Send();
        public abstract void Receive(string message);

        public string GetName()
        {
            return this.name;
        }
    }
}
