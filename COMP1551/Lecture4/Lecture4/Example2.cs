using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    internal class Example2
    {
        class Vehicle
        {
            public Vehicle() { Console.WriteLine("This is a vehicle"); }
            public void Say() { Console.WriteLine("Vehicle"); }
        }
        class  Car : Vehicle
        {
            public Car() { Console.WriteLine("This is a car"); }
            public new void Say() { Console.WriteLine("Car");}
        }
        class Toyota : Car
        {
            public Toyota() { Console.WriteLine("This is Totoya"); }
            public new void Say() { Console.WriteLine(); }
        }
        internal class Program
        {
            static  void Main(string[] args) 
            {
                Vehicle car = new Car();
                car.Say();
            }
        }
    }
}
