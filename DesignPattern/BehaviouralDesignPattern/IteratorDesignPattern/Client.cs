using System;
namespace DesignPattern.BehaviouralDesignPattern.IteratorDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IIterableCollection coll = new CustomIterableCollection();
            IIterator iter = coll.CreateIterator();

            int i = 0;
            while (iter.HasMore())
            {
                string result = iter.GetNext();
                Console.WriteLine(++i + "> " + result);
            }

            Console.ReadLine();
        }
    }
    //The Iterator Pattern is a basic and widely used design pattern.Each language has a large number of data collections as well as structures.
    //Iterator is known to be a behavioral design pattern that allows you to traverse components of a set without revealing the representation underneath(for example: stack, lists, tree, etc.).
}
