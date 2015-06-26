using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
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
            int index = Array.IndexOf(array, 5);
            Console.WriteLine(index);
        }
    }
}
