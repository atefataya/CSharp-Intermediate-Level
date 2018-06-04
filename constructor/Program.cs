using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
        }
        static void UsePoints()
        {
            try
            {
                var customer = new Customer(1, "atef");
                //var customer = new Customer
                //{
                //    Id = 1,
                //    Name = "Atef"
                //};
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
            }
            catch (Exception)
            {

                Console.WriteLine("An expected error occured");
            }
        }
    }
}
