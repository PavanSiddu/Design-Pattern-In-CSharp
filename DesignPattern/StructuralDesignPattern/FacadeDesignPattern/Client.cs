using System;

namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        { 
            FacadeOperator op = new FacadeOperator();
            op.CompleteOrder();

            Console.ReadLine();
        }
    }

    //Facade design pattern is a type of structural design pattern.
    //The main objective of facade design pattern is to provide a simple interface before a complex system.
    //So that the user or client can access the simple interface without knowing the complexity of its sub-system.
    //Facade design patterns are mostly used to hide the dependencies involved in a system from the user.
}
