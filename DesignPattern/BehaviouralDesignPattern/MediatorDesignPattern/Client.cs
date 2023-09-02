using System;

namespace DesignPattern.BehaviouralDesignPattern.MediatorDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();

            Component compA = new ComponentA(mediator);
            Component compB = new ComponentB(mediator);

            mediator.Register(compA);
            mediator.Register(compB);

            compA.Send();

            Console.WriteLine("-------------------");

            compB.Send();
            Console.ReadLine();
        }
    }

    //Mediator Design Pattern is a behavioral design pattern.It is one of the most widely used and important types of design patterns.
    //The Mediator design pattern restricts direct communication between objects by detaching them with the addition of a mediator
    //(i.e.a layer to curb direct interaction between them) that forces communication through it.
}
