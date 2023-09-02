using System;

namespace DesignPattern.BehaviouralDesignPattern.ChainOfResponsibilityPattern
{
    public class FireTruckHandler : AbstractHandler
    {
        public override void Handle(string incomingSuspect)
        {
            if ("FIRE_TRUCK".Equals(incomingSuspect))
            {
                Console.WriteLine("Validate id.");
                return;
            }
            this.nextHandler.Handle(incomingSuspect);
        }
    }
}
