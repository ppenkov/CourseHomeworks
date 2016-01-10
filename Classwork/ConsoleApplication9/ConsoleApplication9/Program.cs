using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int y = int.Parse(Console.ReadLine());
            int z = y;

            if (x > y)
            {
                y = x;
                x = z;
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Няма проблеми");
            }
        }
    }
}
