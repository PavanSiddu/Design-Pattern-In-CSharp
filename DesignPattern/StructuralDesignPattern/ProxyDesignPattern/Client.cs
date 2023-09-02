using System;
using System.Diagnostics;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    // Client - Take use of the Service.
    public class Client
    {
        public static void Main(string[] args)
        {
            // Passing the Proxy in place of RealImage object.
            IImage img = new Proxy("Pic.jpg");

            // Setting Location of the Image
            img.SetLocation(1.0, 0.0);
            double[] loc = img.GetLocation();

            // Setting the Image Border to True
            img.SetBorder(true);

            // Getting Details related to the Image.
            Console.WriteLine("\n-- Image Details --");
            Console.WriteLine("Image Border : " + img.GetBorder());
            Console.WriteLine("Image location : (" + loc[0] + "," + loc[1] + ")");

            // Displaying the Image - Creating the RealImage object
            Console.WriteLine("\n-- Displaying image now --");
            img.Display();
            Console.WriteLine("Image Border : " + img.GetBorder());
            Console.ReadLine();
        }
    }

    //Proxy Design Pattern is a type of structural design pattern which is used whenever we need a placeholder or representational object that can work in place of the real object.
    //The proxy acts as an intermediatory layer between the client and the real object and hence can control the access to the real object, add additional functionality,
    //and even restrict client access.It is also known as Surrogate Pattern.
}
