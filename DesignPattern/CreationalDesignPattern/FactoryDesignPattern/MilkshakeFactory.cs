using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesignPattern
{
    public class MilkshakeFactory
    {
        private Dictionary<MilkshakeName, Milkshake> milkshakeMenu;

        public MilkshakeFactory()
        {
            BuildMilkshakeMenu();
        }

        public Milkshake Prepare(MilkshakeName milkshakeName)
        {
            if (milkshakeName == null)
            {
                Console.WriteLine("Please provide a milkshake name!");
                return null;
            }

            Console.WriteLine(milkshakeName + " ready!");
            return milkshakeMenu[milkshakeName];

        }

        private void BuildMilkshakeMenu()
        {
            milkshakeMenu = new Dictionary<MilkshakeName, Milkshake>();
            milkshakeMenu.Add(MilkshakeName.OreoMilkshake, new OreoMilkshake());
            milkshakeMenu.Add(MilkshakeName.ButterscotchMilkshake, new ButterscotchMilkshake());
            milkshakeMenu.Add(MilkshakeName.VannilaMilkshake, new VanillaMilkshake());
        }
    }
}
