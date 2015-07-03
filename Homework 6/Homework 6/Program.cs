using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int c = int.Parse(Console.ReadLine());

            PrintMaxNumber(a, b,c);
        }
            private static void PrintMaxNumber(int a, int b, int c)
            {
                if (a > b && a > c)
                {
                    Console.WriteLine("The biggest number is:" + a);  
                }
                else if (b>a && b > c)
                {
                    Console.WriteLine("The biggest number is:" + b);
                }
                else
                {
                    Console.WriteLine("The biggest number is:" + c);
                }
            }
        }
}
