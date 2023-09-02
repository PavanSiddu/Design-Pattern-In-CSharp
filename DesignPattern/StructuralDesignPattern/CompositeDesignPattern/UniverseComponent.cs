using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public abstract class UniverseComponent
    {
        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual string Gettype()
        {
            throw new NotSupportedException();
        }

        public virtual UniverseComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual void AddChild(UniverseComponent universeComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void RemoveChild(UniverseComponent universeComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
