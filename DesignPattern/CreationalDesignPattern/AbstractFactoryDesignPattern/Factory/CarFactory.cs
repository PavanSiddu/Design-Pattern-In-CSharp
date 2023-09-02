using DesignPattern.AbstractFactoryDesignPattern.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Factory
{
    public  class CarFactory : AbstractVehicleFactory
    {
        public override Vehicle getVehicle(String type)
        {
            if (type.Equals("Micro"))
            {
                return new MicroCar();
            }
            else if (type.Equals("Mini"))
            {
                return new MiniCar();
            }
            else if (type.Equals("Mega"))
            {
                return new MegaCar();
            }
            else
            {
                return new MiniCar();
            }
        }
    }
}
