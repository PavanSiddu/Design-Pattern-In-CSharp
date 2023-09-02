using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern;
using System;

namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class Tree
    {
        private readonly string Color;
        private readonly int Height;

        public Tree(string color)
        {
            this.Color = color;
            this.Height = 6;
        }
        public string GetColor()
        {
            return Color;
        }

        public int GetHeight()
        {
            return Height;
        }
    }
}
