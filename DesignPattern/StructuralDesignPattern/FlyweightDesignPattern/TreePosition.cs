namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class TreePosition
    {
        private int x;
        private int y;

        public TreePosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }
    }
}
