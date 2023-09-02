using System;

namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class FoodPreparationState : IFoodOrderState
    {
        public void TransitionToNext(FoodOrder order)
        {
            order.SetState(new WaitingToBePickedState());
        }

        public void ShowStatus()
        {
            Console.WriteLine("Food preparation started, waiting for the food to be prepared.");
        }
    }
}
