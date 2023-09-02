namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public interface IFoodOrderState
    {
        void TransitionToNext(FoodOrder order);
        void ShowStatus();
    }
}
