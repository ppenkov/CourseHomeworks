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
            Console.WriteLine("Enter 12 numbers:");
            int[,] matrix = new int[3, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("The matrix from your numbers is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("   " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
