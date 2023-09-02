using System;

namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            FoodOrder order = new FoodOrder();

            order.ShowCurrentStatus();

            order.TransitionToNextState();
            order.ShowCurrentStatus();

            order.TransitionToNextState();
            order.ShowCurrentStatus();

            order.TransitionToNextState();
            order.ShowCurrentStatus();

            order.TransitionToNextState();
            order.ShowCurrentStatus();

            order.TransitionToNextState();
            order.ShowCurrentStatus();


            Console.ReadLine();
        }
    }
    //State Design Patterns belongs to the category of Behavioral design pattern.
    //It is used to allow an object to modify its behavior based on the changes in its internal state.
    //It makes the object behave similarly to finite state machines.
    //It makes the object flexible to alter its state without handling a lot of if / else conditions.
    //State pattern ensures loose coupling between the performance of existing states versus the addition of new states.
}
