using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralDesignPattern.MediatorDesignPattern
{
    public class ComponentB : Component
    {
        public ComponentB(IMediator m) : base("Component-B", m)
        {
        }
        public override void Send()
        {

            string message = "I am good.";
            Console.WriteLine("B is sending: " + message);
            this.mediator.Notify(this, message);
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Component B got: " + message);
        }
    }
}
