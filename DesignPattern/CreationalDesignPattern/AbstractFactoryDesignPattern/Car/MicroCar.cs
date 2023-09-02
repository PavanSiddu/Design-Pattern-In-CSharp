using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Car
{
    public class MicroCar : Car
    {
        public MicroCar(){ }

        public override void setVehicleType()
        {
            carType = "Micro";
        }

        public override void setBaseCost()
        {
            baseCost = 50;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 10;
        }
    }
}
