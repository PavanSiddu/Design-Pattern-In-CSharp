using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            int distance = 10;

            /*
            * Book a Mini Car for a distance of 10 kms
            */
            AbstractVehicleFactory carFactory = FactoryProvider.getVehicleFactory("Car");
            Vehicle miniCar = carFactory.getVehicle("Mini");
            miniCar.book(distance);


            /*
            * Book a Personal Auto for a distance of 10 kms
            */
            AbstractVehicleFactory autoFactory = FactoryProvider.getVehicleFactory("Auto");
            Vehicle personalAuto = autoFactory.getVehicle("Personal");
            personalAuto.book(distance);


            /*
            * Book a Sports Bike for a distance of 10 kms
            */
            AbstractVehicleFactory bikeFactory = FactoryProvider.getVehicleFactory("Bike");
            Vehicle sportsBike = bikeFactory.getVehicle("Sports");
            sportsBike.book(distance);
        }
    }
}
