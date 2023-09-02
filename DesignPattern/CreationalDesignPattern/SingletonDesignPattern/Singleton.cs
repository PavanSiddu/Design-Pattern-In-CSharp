using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());  //Eager initialization
        //private static Singleton instance = null;
        private static object obj = new object();
        public static Singleton GetInstance
        {
            get
            {
                //if (instance == null) // as locks are expensive we should no invoke every time GetInstance is called
                //{
                //    lock (obj)
                //    {
                //        if (instance == null) 
                //            instance = new Singleton();
                //    }
                //}
                return instance.Value;
            }
        }
        private Singleton()
        { 
            counter++;
            Console.WriteLine("Counter Value : " + counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
