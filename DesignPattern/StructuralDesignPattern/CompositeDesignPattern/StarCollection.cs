using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public class StarCollection : UniverseComponent
    {
        string name;
        string type;
        List<UniverseComponent> universeComponents; // A component can hold other components within it

        public StarCollection(string name, string type)
        {
            this.name = name;
            this.type = type;
            this.universeComponents = new List<UniverseComponent>();
        }

        public override string GetName()
        {
            return this.name;
        }

        public override string Gettype()
        {
            return this.type;
        }

        public override UniverseComponent GetChild(int i)
        {
            return universeComponents[i];
        }

        public override void AddChild(UniverseComponent component)
        {
            universeComponents.Add(component);
        }

        public override void RemoveChild(UniverseComponent component)
        {
            universeComponents.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine(this.type + " = " + this.name);
            foreach (UniverseComponent component in this.universeComponents)
            {
                component.Print();
            }
        }
    }
}
