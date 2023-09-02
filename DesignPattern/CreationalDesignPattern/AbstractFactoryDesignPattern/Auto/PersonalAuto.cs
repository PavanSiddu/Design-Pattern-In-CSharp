using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Auto
{
    public class PersonalAuto : Auto
    {
        public PersonalAuto() { }

        public override void setVehicleType()
        {
            shareType = "Personal";
        }

        public override void setBaseCost()
        {
            baseCost = 10;
        }

        public override void setVehicleChargesPerUnitDistance()
        {
            chargesPerUnitDistance = 15;
        }
    }
}
