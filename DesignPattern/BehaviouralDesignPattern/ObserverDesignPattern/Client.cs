using System;

namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            ObserverA a = new ObserverA();
            ObserverB b = new ObserverB();
            ObserverC c = new ObserverC();

            ConcreteSubject publisher = new ConcreteSubject();
            publisher.Attach(a);
            publisher.Attach(b);

            publisher.Notify(new Message("First update\n"));

            publisher.Attach(c);
            publisher.Detach(b);
            publisher.Notify(new Message("Second update\n"));
            Console.ReadLine();
        }
    }
    //Observer design pattern falls under the category of behavioral design patterns.
    //The Observer Pattern maintains a one-to-many relationship among objects, ensuring that when the state of one object is changed, all of its dependent objects are simultaneously informed and updated.
    //This design pattern is also referred to as Dependents.

    //A subject and observer(many) exist in a one-to-many relationship.
    //Here the observers do not have any access to data, so they are dependent on the subject to feed them with information.
}
