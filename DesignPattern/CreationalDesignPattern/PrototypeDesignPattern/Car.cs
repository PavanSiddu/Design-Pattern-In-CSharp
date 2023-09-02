using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDesignPattern
{
    public class Car : Vehicle
    {
        public Car() 
        {
        }

        public Car(Car c) : base(c)  // Calling Parent class to initialize the object
        {
        }

        public override Vehicle Clone()
        {
            return new Car(this); // Cloning current object with exact same functionality
        }
    }
}
