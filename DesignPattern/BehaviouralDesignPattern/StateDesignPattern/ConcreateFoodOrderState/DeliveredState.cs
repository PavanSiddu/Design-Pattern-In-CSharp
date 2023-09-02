using System;


namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class DeliveredState : IFoodOrderState
    {
        public void TransitionToNext(FoodOrder order)
        {
            Console.WriteLine("Food is already delivered to the respective customer");
        }

        public void ShowStatus()
        {
            Console.WriteLine("Food delivered to the Customer.");
        }
    }
}
