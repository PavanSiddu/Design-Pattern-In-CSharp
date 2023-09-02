using System;

namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    public class Speaker : IDevice
    {
        public void On()
        {
            Console.WriteLine("Turn on speaker");
        }

        public void Off()
        {
            Console.WriteLine("Turn off speaker");
        }

        public void Up()
        {
            Console.WriteLine("Increase Volume");
        }

        public void Down()
        {
            Console.WriteLine("Decrease Volume");
        }
    }
}
