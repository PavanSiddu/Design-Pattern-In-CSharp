using System;

namespace DesignPattern.BehaviouralDesignPattern.CommandDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
           Light light = new Light();
           //Speaker speaker = new Speaker();
           //To execute speaker functionality pass speaker variable in place of light
           Invoker invoker = new Invoker(
               new OnCommand(light),
               new OffCommand(light),
               new UpCommand(light),
               new DownCommand(light)
           );
           invoker.ClickOn();
           invoker.ClickOff();
           invoker.ClickUp();
           invoker.ClickDown();


           Console.ReadLine();
        }
    }
    //Command design pattern is a behavioral design pattern(communication pattern among objects)
    //that converts a request or an operation into an object with all the required information such as what method to call, arguments, etc.
}
