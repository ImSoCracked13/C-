using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
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
        static void Main(string[] args)
        {
            MyClass.add(3, 4)
        }
    }
}
