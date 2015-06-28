using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a bigger number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
