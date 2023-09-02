namespace DesignPattern.BehaviouralDesignPattern.TemplateDesignPattern
{
    public abstract class PizzaMaker
    {
        public abstract void SelectBread();

        public abstract void ChooseIngredients();

        public abstract void BakeAtTemp();

        public abstract void AddToppings();

        public abstract void AddCheese();

        public void Make()
        {
            SelectBread();
            ChooseIngredients();
            AddToppings();
            AddCheese();
            BakeAtTemp();
        }
    }
}
