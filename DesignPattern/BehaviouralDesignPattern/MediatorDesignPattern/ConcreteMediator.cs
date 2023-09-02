using System;
using System.Collections.Generic;

namespace DesignPattern.BehaviouralDesignPattern.MediatorDesignPattern
{
    public class ConcreteMediator : IMediator
    {
        private readonly string COMPONENT_A = "Component-A";
        private readonly string COMPONENT_B = "Component-B";

        private Dictionary<string, Component> regCompMap = new Dictionary<string, Component>();

        public void Notify(Component sender, string message)
        {
            string senderName = sender.GetName();
            if (COMPONENT_A.Equals(senderName))
            {
                ReactOnA(message);
            }
            else if (COMPONENT_B.Equals(senderName))
            {
                ReactOnB(message);
            }
        }

        public void Register(Component component)
        {
            this.regCompMap[component.GetName()] = component;
        }

        private void ReactOnA(string message)
        {
            Console.WriteLine("Mediator is in action: ");
            regCompMap[COMPONENT_B].Receive(message);
        }

        private void ReactOnB(string message)
        {
            Console.WriteLine("Mediator is in action: ");
            regCompMap[COMPONENT_A].Receive(message);
        }
    }
}
