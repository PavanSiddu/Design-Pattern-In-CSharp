namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class Rectangle : IShape
    {
        private readonly double length;
        private readonly double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public double GetWidth()
        {
            return width;
        }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
