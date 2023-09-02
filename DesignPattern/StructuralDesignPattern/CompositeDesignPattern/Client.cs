using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            UniverseComponent universe = new StarCollection("The whole universe", "UNIVERSE");
            UniverseComponent milkway = new StarCollection("Milky way", "GALAXY");
            UniverseComponent andromeda = new StarCollection("Andromeda", "GALAXY");
            UniverseComponent canisMajor = new StarCollection("Canis Major", "CONSTELLATION");
            UniverseComponent sirius = new Star("Sirius", "STAR");
            UniverseComponent sun = new Star("Sun", "STAR");
            UniverseComponent mirach = new Star("Mirach", "STAR");
            UniverseComponent alpheratz = new Star("Alpheratz", "STAR");

            universe.AddChild(milkway);
            universe.AddChild(andromeda);
            milkway.AddChild(canisMajor);
            canisMajor.AddChild(sirius);
            milkway.AddChild(sun);
            andromeda.AddChild(mirach);
            andromeda.AddChild(alpheratz);
            universe.Print();


            Console.ReadLine();
        }
    }

    //Composite pattern is a structural design pattern which is used to apply common methods to a collection of objects where a partial or complete hierarchy can be established.
    //Simply speaking, if a client wishes to interact with components which have a tree relationship with each other while being agnostic of whether the component is a parent or a child,
    //we make use of composite design pattern to achieve extensibility and modularity in our code
}
