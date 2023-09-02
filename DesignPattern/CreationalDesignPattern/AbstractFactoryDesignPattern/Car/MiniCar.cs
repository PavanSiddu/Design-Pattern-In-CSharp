using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Car
{
    public class MiniCar : Car
    {
        public MiniCar() { }

        public override void setVehicleType()
        {
            carType = "Mini";
        }

        public override void setBaseCost()
        {
            baseCost = 100;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 20;
        }
    }
}
