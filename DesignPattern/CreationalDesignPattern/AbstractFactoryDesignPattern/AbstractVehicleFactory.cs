using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public abstract class AbstractVehicleFactory
    {
        public abstract Vehicle getVehicle(String type);
    }
}
