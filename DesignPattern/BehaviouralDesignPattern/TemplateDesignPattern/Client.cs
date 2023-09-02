using System;

namespace DesignPattern.BehaviouralDesignPattern.TemplateDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            PizzaMaker cheeseCornMaker = new SimpleCheeseCornPizzaMaker();

            cheeseCornMaker.Make();

            Console.ReadLine();
        }
    }

    //The template method design pattern falls under the category of behavioral design pattern.
    //It describes a technique (also known as an algorithm) that is in the form of a skeleton of functions.
    //The child classes are responsible for implementing the specifics for this method.
    //The parent class maintains the algorithm's basic framework as well as sequencing.
}
