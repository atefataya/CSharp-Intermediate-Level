using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{


    class Program
    {
        static void Main(string[] args)
        {
           //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine("successful");
            }
               
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 3));
            Console.WriteLine(calculator.Add(1, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 33, 44, 4 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
