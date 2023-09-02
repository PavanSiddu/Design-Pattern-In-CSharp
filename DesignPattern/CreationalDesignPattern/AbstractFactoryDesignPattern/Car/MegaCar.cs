using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Car
{
    public class MegaCar : Car
    {
        public MegaCar() { }

        public override void setVehicleType()
        {
            carType = "Mega";
        }

        public override void setBaseCost()
        {
            baseCost = 150;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 30;
        }
    }
}
