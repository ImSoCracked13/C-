using Lecture4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    internal class QuadraticEquation
    {
        private double a; 
        private double b; 
        private double c;
        private double D;
        private double? x1;
        private double? x2;

        public void Calculate(double p1, double p2, double p3)
        {
            a = p1;
            b = p2; 
            c = p3;
            D = Convert.ToDouble(b * b - 4 * a * c);
            if ((a != 0) && (D >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 *a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
            }
            else
            {
                x1 = null; 
                x2 = null;
            }
        }
        public double? getx1()
        {
            return x1;
        }
        public double? getx2()
        { 
            return x2; 
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        QuadraticEquation
    }
}