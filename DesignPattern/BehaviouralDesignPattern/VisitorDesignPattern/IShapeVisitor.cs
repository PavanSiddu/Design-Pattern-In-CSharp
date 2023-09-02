namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Square square);
        void Visit(Rectangle rectangle);
    }
}
