using System;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public class Star : UniverseComponent
    {
        string name;
        string type;
        public Star(string name , string type)
        {
            this.name = name;
            this.type = type;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override string Gettype()
        { 
            return this.type;
        }

        public override void Print()
        {
            Console.WriteLine($"{this.type} = {this.name}");
        }
    }
}
