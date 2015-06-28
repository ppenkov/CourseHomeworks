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
            int[,] matrix = new int[5, 6];
            int a = 31;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    a = a - 1;
                    Console.Write(a + "  "); 
                }         
                Console.WriteLine();
            }
        }
    }
}
