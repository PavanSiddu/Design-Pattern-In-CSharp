namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class Circle : IShape
    {
        private readonly double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
