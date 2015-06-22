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
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= x; counter++)
            {
                    Console.WriteLine(counter);
            }
        }
    }
}
