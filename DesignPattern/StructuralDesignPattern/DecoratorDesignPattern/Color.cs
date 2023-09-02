using System;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class Color : IColor
    {
        public string Name { get; set; }
        public Color(string colorName)
        {
            this.Name = colorName;
        }
        public void Fill()
        {
            Console.WriteLine($"Fill {this.Name} Color");
        }
    }
}
