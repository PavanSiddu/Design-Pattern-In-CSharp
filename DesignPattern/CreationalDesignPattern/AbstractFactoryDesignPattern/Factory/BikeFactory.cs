using DesignPattern.AbstractFactoryDesignPattern.Bike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Factory
{
    public class BikeFactory : AbstractVehicleFactory
    {
        public override Vehicle getVehicle(String type)
        {
            if (type.Equals("Normal"))
            {
                return new NormalBike();
            }
            else if (type.Equals("Sports"))
            {
                return new SportsBike();
            }
            else
            {
                return new NormalBike();
            }
        }
    }
}
