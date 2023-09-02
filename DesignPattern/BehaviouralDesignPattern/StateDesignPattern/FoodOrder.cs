namespace DesignPattern.BehaviouralDesignPattern.StateDesignPattern
{
    public class FoodOrder
    {
        private IFoodOrderState state = new OrderInitiatedState();

        public void SetState(IFoodOrderState state)
        {
            this.state = state;
        }

        public IFoodOrderState GetState()
        {
            return state;
        }

        public void TransitionToNextState()
        {
            state.TransitionToNext(this);
        }

        public void ShowCurrentStatus()
        {
            state.ShowStatus();
        }
    }
}
