using System;

namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class AreaVisitor : IShapeVisitor
    {
        private double area;

        public void Visit(Circle circle)
        {
            area = Math.PI * Math.Pow(circle.GetRadius(), 2);
        }

        public void Visit(Square square)
        {
            area = 2 * square.GetLength();
        }

        public void Visit(Rectangle rectangle)
        {
            area = rectangle.GetLength() * rectangle.GetWidth();
        }

        public double Get()
        {
            return this.area;
        }
    }
}
