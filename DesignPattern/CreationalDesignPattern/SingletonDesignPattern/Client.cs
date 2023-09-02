using System.Threading.Tasks;
using System;

namespace DesignPattern.SingletonDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
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
