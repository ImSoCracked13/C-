// See https://aka.ms/new-console-template for more information
using System {
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
                Console.WriteLine("The Result is : {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("No Solution!");
            }
        }
    }
}`