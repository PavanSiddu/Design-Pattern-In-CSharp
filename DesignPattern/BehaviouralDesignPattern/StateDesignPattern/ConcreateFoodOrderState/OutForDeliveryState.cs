using System;

namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class OutForDeliveryState : IFoodOrderState
    {
        public void TransitionToNext(FoodOrder order)
        {
            order.SetState(new DeliveredState());
        }

        public void ShowStatus()
        {
            Console.WriteLine("Food picked and out for delivery, waiting for food to be delivered.");
        }
    }
}
