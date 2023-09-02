namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
