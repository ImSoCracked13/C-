using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace Program
{
    static class MyClass
    {
        static int add(int a, int b)
        {
            return a + b;
        }
    }

    public class MyProject
    {
        static void Main(string[] args)oo
        {
            Console.WriteLine("Enter an integer for a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer for b:");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum == MyClass.add(a, b);
            Console.WriteLine("a + b = {0}", sum);
        }
    }
}
