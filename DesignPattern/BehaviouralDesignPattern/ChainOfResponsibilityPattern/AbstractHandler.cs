namespace DesignPattern.BehaviouralDesignPattern.ChainOfResponsibilityPattern
{
    public abstract class AbstractHandler : IHandler
    {
        protected IHandler nextHandler;

        public void SetNextHandler(IHandler handler)
        { 
            this.nextHandler = handler;
        }
        public abstract void Handle(string incomingSuspect);
    }
}
