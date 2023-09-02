using System;
using System.Xml.Linq;

namespace DesignPattern.FactoryDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        { 
            MilkshakeFactory milkshakeFactory = new MilkshakeFactory();

            OreoMilkshake oreoMilkshake = (OreoMilkshake)milkshakeFactory.Prepare(MilkshakeName.OreoMilkshake);

            ButterscotchMilkshake butterscotchMilkshake = (ButterscotchMilkshake)milkshakeFactory.Prepare(MilkshakeName.ButterscotchMilkshake);

            VanillaMilkshake vannilaMilkshake = (VanillaMilkshake)milkshakeFactory.Prepare(MilkshakeName.VannilaMilkshake);


            Console.ReadLine();
        }
    }

    //Factory design pattern is a creational design pattern that separates the logic of creating objects from the client code.
    //The factory class in the factory design pattern is responsible for creating objects based on the request from the client.

    //Factory design pattern delegates the responsibility of creating objects to a factory class.
    //Factory class has a factory method responsible for creating the requested object.
    //This design pattern is also known as Simple Factory Pattern.
}
