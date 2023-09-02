using System;

namespace DesignPattern.BehaviouralDesignPattern.ChainOfResponsibilityPattern
{
    public class AmbulanceHandler : AbstractHandler
    {
        public override void Handle(string incomingSuspect)
        {
            if ("AMBULANCE".Equals(incomingSuspect))
            {
                Console.WriteLine("Validate id quickly.");
                Console.WriteLine("Let go.");
                return;
            }
            Console.WriteLine("Stop right there.");
            //For last handler donot execute Handle method , because next hanler will be null
            //this.nextHandler.Handle(incomingSuspect);
        }
    }
}
