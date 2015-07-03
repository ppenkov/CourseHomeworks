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

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Enter a number:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number:");
                int c = int.Parse(Console.ReadLine());
                Print(a, b, c);
            }
        }
        public static void Print(int a, int b, int c)
        {
                Console.WriteLine("The result is:"+ (a * b * c)); 
        }
    }
}
