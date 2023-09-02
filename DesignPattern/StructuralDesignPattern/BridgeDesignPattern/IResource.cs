using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    // Implementor
    public interface IResource
    {
        void Snippet();
    }

    // Concrete Implementor 1
    public class Artist : IResource
    {
        public void Snippet()
        {
            Console.WriteLine("Artist's Snippet is here !!!");
        }
    }

    // Concrete Implementor 2
    public class Album : IResource
    {
        public void Snippet()
        {
            Console.WriteLine("Hola !!!, This is my Album Description ...");
        }
    }
}
