using System;
using System.Collections.Generic;

namespace DesignPattern.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(10),
                new Square(10),
                new Square(5),
                new Rectangle(10, 2)
            };

            AreaVisitor areaVisitor = new AreaVisitor();
            PerimeterVisitor perimeterVisitor = new PerimeterVisitor();

            foreach(IShape shape in shapes)
            {
                shape.Accept(areaVisitor);
                double area = areaVisitor.Get();

                Console.WriteLine($"Area of {shape.GetType().Name}: {Math.Round(area,2)}");
            }

            Console.WriteLine("---------------------------------");

            foreach (IShape shape in shapes)
            {
                shape.Accept(perimeterVisitor);
                double perimeter = perimeterVisitor.Get();

                Console.WriteLine($"Perimeter of {shape.GetType().Name}: {Math.Round(perimeter, 2)}");
            }


            Console.ReadLine();
        }
    }

    //A visitor design pattern is a behavioral design pattern used to decouple the logic/algorithm from the objects on which they operate.
    //The logic is moved to separate classes called visitors. Each visitor is responsible for performing a specific operation.
}
