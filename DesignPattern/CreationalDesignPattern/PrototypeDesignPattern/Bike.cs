using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDesignPattern
{
    public class Bike : Vehicle
    {
        public Bike()
        {  
        }

        public Bike(Bike b) : base(b)  // Calling Parent class to initialize the object
        { 
        }
        public override Vehicle Clone()
        {
            return new Bike(this); // Cloning current object with exact same functionality
        }
    }
}
