namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class Square : IShape
    {
        private readonly double length;

        public Square(double length)
        {
            this.length = length;
        }

        public double GetLength()
        {
            return length;
        }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
