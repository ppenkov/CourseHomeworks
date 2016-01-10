using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 5)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even!");
                }

                else
                {
                    Console.WriteLine("The number is odd!");
                }
            }

            else if (number >= 6 && number <= 15)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("Числото се дели на 3 без остатък!");
                }

                else
                {
                    Console.WriteLine("Остатък след деление на 3:");
                }
                    
            }
            else
            {
                if (number == 0)
                {
                    Console.WriteLine("Zero");
               }
                {
                    if (number > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                }
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                }
            }
        }

    }
}
