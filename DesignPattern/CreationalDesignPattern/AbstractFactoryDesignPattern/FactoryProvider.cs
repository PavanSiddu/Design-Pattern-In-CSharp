using DesignPattern.AbstractFactoryDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class FactoryProvider
    {
        public static AbstractVehicleFactory getVehicleFactory(String factoryType)
        {
            if (factoryType.Equals("Car"))
            {
                return new CarFactory();
            }
            else if (factoryType.Equals("Auto"))
            {
                return new AutoFactory();
            }
            else if (factoryType.Equals("Bike"))
            {
                return new BikeFactory();
            }
            else
            {
                return new CarFactory();
            }
        }
    }
}
