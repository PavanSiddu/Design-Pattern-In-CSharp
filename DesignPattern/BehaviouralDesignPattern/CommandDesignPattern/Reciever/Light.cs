using System;

namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    public class Light : IDevice
    {
        public void On()
        {
            Console.WriteLine("Turn on light");
        }

        public void Off()
        {
            Console.WriteLine("Turn off light");
        }

        public void Up()
        {
            Console.WriteLine("Increase brightness");
        }

        public void Down()
        {
            Console.WriteLine("Decrease brightness");
        }
    }
}
