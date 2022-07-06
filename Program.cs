using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 4;
            int z = 5;

            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * z);

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"17 diveded by 4 = {quotient} with a remainder of {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));

        }

        static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
            
        }

    }
}

