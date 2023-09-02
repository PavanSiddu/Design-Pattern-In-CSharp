using DesignPattern.AbstractFactoryDesignPattern.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern.Factory
{
    public class AutoFactory : AbstractVehicleFactory
    {
        public override Vehicle getVehicle(String type)
        {
            if (type.Equals("Personal"))
            {
                return new PersonalAuto();
            }
            else if (type.Equals("Shared"))
            {
                return new SharedAuto();
            }
            else
            {
                return new PersonalAuto();
            }
        }
    }
}
