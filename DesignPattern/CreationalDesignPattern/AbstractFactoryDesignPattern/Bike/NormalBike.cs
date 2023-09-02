using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Bike
{
    public  class NormalBike : Bike
    {
        public NormalBike() { }
        public override void setVehicleType()
        {
            bikeType = "Normal";
        }

        public override void setBaseCost()
        {
            baseCost = 20;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 5;
        }
    }
}
