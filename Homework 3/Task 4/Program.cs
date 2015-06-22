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
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= x; counter++)
            {
                if (counter % 3 == 0 && counter % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }
        }
    }
}
