namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    //abstract decorator class
    public abstract class ColorDecorator : IColor
    {
        //base class object
        protected IColor colored;
        public string Name { get; set; }
        //constructor with base class object as the parameter
        public ColorDecorator(IColor colored)
        {
            this.colored = colored;
        }

        public virtual void Fill()
        {
            colored.Fill();
        }
    }
}
