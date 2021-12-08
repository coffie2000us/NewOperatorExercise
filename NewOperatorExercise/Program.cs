using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int rem = a % b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {rem}");

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle} ");
        }
    }
}
