using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp1551_Demo
{
    internal class Lecture2
    { 
        static public void Var_Const_Ex()
        {
            int MyVariable;
            int MyNewVariable = 10;
            MyVariable = 5;
            MyNewVariable = 15;
            Console.WriteLine("Value: {0} {1}", MyVariable, MyNewVariable);

            const double PI = 3.14;
            double radius = 2.5;
            double area = PI * radius * radius;
            Console.WriteLine("Area: {0}", area);

            int IntegerNumber = 5;
            double RealNumber = 5.1223345;
            char Symbol = 'A';
            string Text = "Hello";
            bool Flag = true;
            Console.WriteLine(IntegerNumber);
            Console.WriteLine(RealNumber);
            Console.WriteLine(Symbol);
            Console.WriteLine(Text);
            Console.WriteLine(Flag);

            int IntegerNumber1 = 5;
            double RealNumber1 = 5.5;
            RealNumber1 = (double)IntegerNumber1;
            IntegerNumber1 = (int)5.55;
            Console.WriteLine("IntegerNumber = {0}", IntegerNumber1);
            Console.WriteLine("RealNumber1 = {0}", RealNumber1);
        }

        static public void Logical_Express()
        {
            double UserInput;
            bool Flag;
            Console.WriteLine("Enter a testing grade:");
            UserInput = Convert.ToDouble(Console.ReadLine());
            Flag = (UserInput > 5.0);
            Console.WriteLine("You passed!, {0}", Flag);
        }

        static public void If_Ex()
        {
            double test_grade;
            Console.WriteLine("Enter your test grade:");
            test_grade = Convert.ToDouble(Console.ReadLine());
            if(test_grade > 5.0)
            {
                if (test_grade > 8.0)
                    Console.WriteLine("Merit");
                else
                    Console.WriteLine("Pass");
                Console.WriteLine("Congratulation!");
            }
            else
            {
                Console.WriteLine("Retake please!");
                Console.WriteLine("See you in next class.");
            }
        }

        static public void For_Ex()
        {
            int i;
            Console.WriteLine("Counting from 1 to 10");
            for(i = 0; i < 10; i++) //i = i + 1
            {
                Console.WriteLine(i + 1);
            }
        }

        static public void While_Ex()
        {
            int UserInput;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Counting down from {0} to 0", UserInput);

            while(UserInput > 0)
            {
                Console.WriteLine(UserInput);
                UserInput = UserInput - 1;
            }
        }

        static public void Array_Ex()
        {
            string[] names = { "Nam", "Son", "Hai", "Binh" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static public void Precision_Add()
        {
            double a = 5.0;
            double b = 0.0000000003;

        }
     }
} 