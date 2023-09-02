using System;

namespace DesignPattern.BehaviouralDesignPattern.TemplateDesignPattern
{
    public class SimpleCheeseCornPizzaMaker : PizzaMaker
    {
        public override void SelectBread()
        {
            Console.WriteLine("Selecting Bread...");
        }

        public override void ChooseIngredients()
        {
            Console.WriteLine("Selecting ingredients...");
        }

        public override void BakeAtTemp()
        {
            Console.WriteLine("Baking at temp...");
        }

        public override void AddToppings()
        {
            Console.WriteLine("Adding Toppings...");
        }

        public override void AddCheese()
        {
            Console.WriteLine("Adding Cheese...");
        }
    }
}
