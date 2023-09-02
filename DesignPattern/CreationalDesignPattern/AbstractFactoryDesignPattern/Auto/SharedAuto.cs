using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Auto
{
    public  class SharedAuto : Auto
    {
        public SharedAuto() { }

        public override void setVehicleType()
        {
            shareType = "Shared";
        }

        public override void setBaseCost()
        {
            baseCost = 0;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 10;
        }
    }
}
