using System;

namespace MyProject
{
    public class ArrayHandler
    {
        private int maxPosition;
        private int minPosition;

        public void Initialize(int[] array)
        {
            int i;
            Random randomValue = new Random();

            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(randomValue.Next(1, 100));
            }
        }

        public void Display(int[] array)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. {1}", i, array[i]);
            }
        }

        public int FindMaximumValue(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < 10; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxPosition = i;
                }
            }

            return max;
        }

        public int FindMinimumValue(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < 10; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minPosition = i;
                }
            }

            return min;
        }

        public int GetPositionOfMaximum()
        {
            return maxPosition;
        }

        public int GetPositionOfMinimum()
        {
            return minPosition;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            ArrayHandler arrayHandler = new ArrayHandler();

            arrayHandler.Initialize(myArray);
            arrayHandler.Display(myArray);

            Console.WriteLine("Max is: {0}", arrayHandler.FindMaximumValue(myArray));
            Console.WriteLine("Max's Position is: {0}", arrayHandler.GetPositionOfMaximum());

            Console.WriteLine("Min is: {0}", arrayHandler.FindMinimumValue(myArray));
            Console.WriteLine("Min's position is: {0}", arrayHandler.GetPositionOfMinimum());
        }
    }
}
