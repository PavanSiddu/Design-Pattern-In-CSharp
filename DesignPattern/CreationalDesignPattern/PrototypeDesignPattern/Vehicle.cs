using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDesignPattern
{
    public abstract class Vehicle
    {
        public int seats;
        public int tyres;
        public string color;
        public string fuel;

        public Vehicle()
        { // Default Constructor

        }

        public Vehicle(Vehicle v)
        { // Parameterized Constructor
            if (v != null)
            { // Checking passed object is null or not
              // Copying values from original object into the prototyped object
                this.seats = v.seats;
                this.tyres = v.tyres;
                this.color = v.color;
                this.fuel = v.fuel;
            }
        }

        public abstract Vehicle Clone(); // Abstract Clone() method - Child classes implement this method 

        public override string ToString()
        { // Overriding toString() method so that we can get desired print format
            return "Seats: " + this.seats + "\nTyres: " + this.tyres + "\nColor: " + this.color + "\nFuel: " + this.fuel + "\n";
        }
    }
}
