using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke
            (
                () => FromEmployee(),
                () => FromStudent()
            );

            Console.ReadLine();
        }

        private static void FromStudent()
        {
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("From Student");
        }

        private static void FromEmployee()
        {
            Singleton employee = Singleton.GetInstance;
            employee.PrintDetails("From Employee");
        }
    }
}
