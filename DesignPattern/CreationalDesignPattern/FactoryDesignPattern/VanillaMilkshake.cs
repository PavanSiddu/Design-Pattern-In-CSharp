namespace DesignPattern.FactoryDesignPattern
{
    public class VanillaMilkshake : Milkshake
    {
        public string name;

        public VanillaMilkshake()
        {
            this.name = MilkshakeName.VannilaMilkshake.ToString();
        }
    }
}
