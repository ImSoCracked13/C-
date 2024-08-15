// See https://aka.ms/new-console-template for more information
using System;
namespace MyNameSpace
{
    class HelloWorld
    {
        static void QuadraticEquation(double a, double b, double c)
        {
            double x1, x2, D;
            D = Convert.ToDouble(b * b - 4 * a * c);
            if ((a != 0) & (D >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 * a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("The result is: {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("No solutions");
            }
        }
        static void Main(string[] args)
        {
            double v1, v2, v3;
            Console.WriteLine("Enter values for a, b and c:");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            v3 = Convert.ToDouble(Console.ReadLine());
            QuadraticEquation(v1, v2, v3);
        }
    }
}
