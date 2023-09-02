using System;

namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Game game = new Game();

            game.AddTree(1, 3, "green");
            game.AddTree(2, 5, "brown");
            game.AddTree(4, 8, "green");
            game.AddTree(4, 9, "green");
            game.AddTree(5, 3, "brown");

            Console.ReadLine();
        }
    }

    //Flyweight design patterns are structural design patterns that help to reduce the memory usage
    //when creating numerous objects by sharing their common states.
}
