using System;


namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class WaitingToBePickedState : IFoodOrderState
    {
        public void TransitionToNext(FoodOrder order)
        {
            order.SetState(new OutForDeliveryState());
        }

        public void ShowStatus()
        {
            Console.WriteLine("Food prepared and waiting to be picked.");
        }
    }
}
