using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Bike
{
    public class SportsBike : Bike
    {
        public SportsBike(){ }
        public override void setVehicleType()
        {
            bikeType = "Sports";
        }

        public override void setBaseCost()
        {
            baseCost = 40;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 15;
        }
    }
}
