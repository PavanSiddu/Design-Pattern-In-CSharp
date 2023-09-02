using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderDesignPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Customer customer = new CustomerBuilder()
                .FirstName("Tony")
                .LastName("Stark")
                .PrimaryEmail("tonystark@abc.com")
                .PrimaryMobileNumber("1234567890")
                .Build();

            Console.WriteLine(customer.toString());

            Console.ReadLine();
        }
    }
}
