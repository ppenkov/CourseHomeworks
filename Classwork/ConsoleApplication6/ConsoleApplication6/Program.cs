using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
            {1, 2, 3, 4,},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix [i, j] % 2 == 1)
                    {
                        matrix[i, j] *= 2;
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
