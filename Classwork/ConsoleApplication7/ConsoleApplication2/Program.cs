using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            PrintArray(array);
           
        }

        private static void PrintArray(int[] array)
        {
            for (int j = array.Length-1; j >= 0; j--)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
