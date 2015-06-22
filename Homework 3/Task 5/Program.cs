using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth number:");
            int e = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < 1; counter = 1)
            {
                if (a > b && a > c && a > d && a > e)
                {
                    Console.WriteLine("The highest number is:" + a);
                }
                else if (b > a && b > c && b > d && b > e)
                {
                    Console.WriteLine("The highest number is:" + b);
                }
                else if (c > a && c > b && c > d && c > e)
                {
                    Console.WriteLine("The highest number is:" + c);
                }
                else if (d > a && d > b && d > c && d > e)
                {
                    Console.WriteLine("The highest number is:" + d);
                }
                else if (e > a && e > b && e > c && e > d)
                {
                    Console.WriteLine("The highest number is:" + e);
                }
                if (a < b && a < c && a < d && a < e)
                {
                    Console.WriteLine("The lowest number is:" + a);
                }
                else if (b < a && b < c && b < d && b < e)
                {
                    Console.WriteLine("The lowest number is:" + b);
                }
                else if (c < a && c < b && c < d && c < e)
                {
                    Console.WriteLine("The lowest number is:" + c);
                }
                else if (d < a && d < b && d < c && d < e)
                {
                    Console.WriteLine("The lowest number is:" + d);
                }
                else if (e < a && e < b && e < c && e < d)
                {
                    Console.WriteLine("The lowest number is:" + e);
                }
            }
        }
    }
}
