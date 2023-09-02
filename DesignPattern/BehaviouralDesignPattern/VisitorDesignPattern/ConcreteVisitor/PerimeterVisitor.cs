using System;

namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class PerimeterVisitor : IShapeVisitor
    {
        private double perimeter;

        public void Visit(Circle circle)
        {
            perimeter = 2 * Math.PI * circle.GetRadius();
        }

        public void Visit(Square square)
        {
            perimeter = 4 * square.GetLength();
        }

        public void Visit(Rectangle rectangle)
        {
            perimeter = 2 * (rectangle.GetLength() + rectangle.GetWidth());
        }

        public double Get()
        {
            return this.perimeter;
        }
    }
}
