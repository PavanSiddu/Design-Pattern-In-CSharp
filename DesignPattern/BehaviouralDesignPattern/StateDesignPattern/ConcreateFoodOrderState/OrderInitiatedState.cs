using System;

namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class OrderInitiatedState : IFoodOrderState
    {
        public void TransitionToNext(FoodOrder order)
        {
            order.SetState(new OrderPlacedState());
        }

        public void ShowStatus()
        {
            Console.WriteLine("Order initiated, waiting for the order to be placed.");
        }
    }
}
