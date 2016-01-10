using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = int.MinValue;
            int min = int.MaxValue;
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }

                if (i % 2 == 1 && array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine("The max even index number is:" + maxIndex + " " + max);
            Console.WriteLine("The min even index number is:" + minIndex + " " + min);
        }
    }
}
