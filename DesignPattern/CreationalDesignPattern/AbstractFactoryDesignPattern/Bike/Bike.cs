using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Bike
{
    public abstract class Bike : Vehicle
    {
        public string bikeType;
        public int baseCost;
        public int chargesPerUnitDistance;

        public void book(int distance)
        {
            setVehicleType();
            setBaseCost();
            setVehicleChargesPerUnitDistance();
            int cost = calculateCostOfBooking(distance);
            Console.WriteLine("You have booked a " + bikeType + " Bike for a distance of " + distance + " kms at a total cost of " + cost + ". ");
        }

        public int calculateCostOfBooking(int distance)
        {
            return baseCost + chargesPerUnitDistance * distance;
        }
        public abstract void setVehicleType();
        public abstract void setBaseCost();
        public abstract void setVehicleChargesPerUnitDistance();
    }
}
