using System;

namespace DesignPattern.BehaviouralDesignPattern.MediatorDesignPattern
{
    public class ComponentA : Component
    {
        public ComponentA(IMediator m) : base("Component-A" , m)
        {
        }
        public override void Send()
        {

            string message = "I am good.";
            Console.WriteLine("A is sending: " + message);
            this.mediator.Notify(this, message);
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Component A got: " + message);
        }
    }
}
