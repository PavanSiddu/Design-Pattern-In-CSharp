using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>(); // List for Original objects
            List<Vehicle> vehiclesCopy = new List<Vehicle>(); // List for Cloned objects

            Bike b1 = new Bike(); // Demo Bike object
            b1.seats = 1;
            b1.tyres = 2;
            b1.color = "Black";
            b1.fuel = "Petrol";
            vehicles.Add(b1);

            Car c1 = new Car(); // Demo Car object
            c1.seats = 5;
            c1.tyres = 4;
            c1.color = "White";
            c1.fuel = "Electric";
            vehicles.Add(c1);

            foreach(Vehicle vehicle in vehicles)
            { // cloning each object of 'vehiles' list
                vehiclesCopy.Add(vehicle.Clone());
            }
            Console.WriteLine("Original Objects:-\n");
            foreach(Vehicle vehicle in vehicles)
            { // Printing Original objects
                Console.WriteLine(vehicle.ToString());
                Console.WriteLine("---------------------------------------------------------");
            }
            Console.WriteLine("\n\n\nPrototyped Objects:-\n");
            foreach(Vehicle vehicle in vehiclesCopy)
            { // Printing cloned objects
                Console.WriteLine(vehicle.ToString());
                Console.WriteLine("---------------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
