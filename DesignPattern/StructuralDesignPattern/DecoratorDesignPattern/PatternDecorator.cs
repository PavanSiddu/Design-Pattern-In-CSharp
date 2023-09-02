using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class PatternDecorator : ColorDecorator
    {
        public PatternDecorator(IColor colored) : base(colored)
        {
        }
        public override void Fill()
        { 
            colored.Fill();
            AddPattern(colored);
        }
        private void AddPattern(IColor colored)
        {
            Console.WriteLine($"Adding Pattern to {colored.Name}");
        }
    }
}
