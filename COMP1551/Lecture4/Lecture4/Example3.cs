using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    internal class Myclass
    {
        public void Call(int p) 
        {
            Console.WriteLine("This is an integer");
        }
        public void Call(double p) 
        {
            Console.WriteLine("This is a real number");
        }
        public void Call(char p)
        {
            Console.WriteLine("This is a letter");
        }
        public void Call(string p) 
        {
            Console.WriteLine("This is a text");
        }
        public void Sum(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.Call(1);
            myclass.Call(2.5);
            myclass.Call("a");
            myclass.Call("GreenWich");
            myclass.Sum(1, 2);
            myclass.Sum(1.5, 2.5);
        }
    }
}
