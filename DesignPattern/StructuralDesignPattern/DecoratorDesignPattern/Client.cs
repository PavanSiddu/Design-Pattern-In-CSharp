using System;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IColor black = new Color("Black");
            IColor pattern = new PatternDecorator(new Color("Blue"));

            Console.WriteLine("Style: Solid");
            black.Fill();

            Console.WriteLine("Style: Pattern");
            pattern.Fill();

            Console.ReadLine();
        }

        //In object-oriented programming, the decorator pattern is a structural design pattern that allows behaviour and functionality to be dynamically added to an object without affecting the behaviour of other objects in the same class.
        //Because it offers a wrapper to an existing class, the decorator design pattern is also known as Wrapper.
        //To implement the wrapper, this approach uses abstract classes or interfaces with composition.
        //Decorator classes are used to extend the functionality of the base class.
    }
}
