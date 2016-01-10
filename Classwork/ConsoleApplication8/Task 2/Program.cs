using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 8, 11, 15 };
            int[] array2 = new int[] { 8, 2, 5, 3, 12 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        Console.WriteLine(array[i]);
                        break;
                    }
                }
            }
       
        }
    }
}
