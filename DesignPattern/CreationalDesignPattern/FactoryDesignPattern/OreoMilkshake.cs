namespace DesignPattern.FactoryDesignPattern
{
    public class OreoMilkshake : Milkshake
    {
        public string name;

        public OreoMilkshake()
        {
            this.name = MilkshakeName.OreoMilkshake.ToString();
        }
    }
}
