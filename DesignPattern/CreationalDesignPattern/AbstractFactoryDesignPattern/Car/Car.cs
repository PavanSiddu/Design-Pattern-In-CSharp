using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Car
{
    public abstract class Car : Vehicle
    {
        public string carType;
        public int baseCost;
        public int chargesPerUnitDistance;

        public void book(int distance)
        {
            setVehicleType();
            setBaseCost();
            setVehicleChargesPerUnitDistance();
            int cost = calculateCostOfBooking(distance);
            Console.WriteLine("You have booked a " + carType + " Car for a distance of " + distance + " kms at a total cost of " + cost + ". ");
        }

        public int calculateCostOfBooking(int distance)
        {
            int serviceCharge = 3;
            return baseCost + chargesPerUnitDistance * distance + serviceCharge;
        }
        public abstract void setVehicleType();
        public abstract void setBaseCost();
        public abstract void setVehicleChargesPerUnitDistance();
    }
}
