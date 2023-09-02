using System;

namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class OrderPlacedState : IFoodOrderState
    {
        public void TransitionToNext(FoodOrder order)
        {
            order.SetState(new FoodPreparationState());
        }

        public void ShowStatus()
        {
            Console.WriteLine("Order placed, waiting for the food to be started preparing.");
        }
    }
}
