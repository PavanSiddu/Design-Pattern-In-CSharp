using System;

namespace DesignPattern.BehaviouralDesignPattern.ChainOfResponsibilityPattern
{
    public class CivilianVehicleHandler : AbstractHandler
    {
        public override void  Handle(string incomingSuspect)
        {
            if ("CIVILIAN_SUV".Equals(incomingSuspect))
            {
                Console.WriteLine("Validate id.");
                Console.WriteLine("Do exhaustive search.");
                Console.WriteLine("Minor interrogation.");
                return;
            }
            this.nextHandler.Handle(incomingSuspect);
        }
    }
}
