namespace DesignPattern.FactoryDesignPattern
{
    public class ButterscotchMilkshake : Milkshake
    {
        public string name;

        public ButterscotchMilkshake()
        {
            this.name = MilkshakeName.ButterscotchMilkshake.ToString();
        }
    }
}
