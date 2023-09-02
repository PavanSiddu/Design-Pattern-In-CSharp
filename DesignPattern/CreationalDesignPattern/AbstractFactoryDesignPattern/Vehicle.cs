using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public interface Vehicle
    {
        void book(int distance);
        int calculateCostOfBooking(int distance);
        void setVehicleType();
        void setBaseCost();
        void setVehicleChargesPerUnitDistance();
    }
}
