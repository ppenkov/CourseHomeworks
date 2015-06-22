using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int counter = 1; ; counter ++)
            {
                Console.WriteLine("Enter a number:");
                int y = int.Parse(Console.ReadLine());
                if (y == 0)
                {
                    break;
                }
                else
                {
                    result = result + y;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
