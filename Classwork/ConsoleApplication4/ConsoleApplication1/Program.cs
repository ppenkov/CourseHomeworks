using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3та_задача_вариант_II
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers:");

            int biggest = 0;
            int smallest = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Number {0}: ", i);
                int number = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    biggest = number;
                    smallest = number;
                }
                else
                {
                    if (number > biggest)
                    {
                        biggest = number;
                    }
                    else if (number < smallest)
                    {
                        smallest = number;
                    }
                }
            }

            Console.WriteLine("Biggest: {0}\nSmallest: {1}", biggest, smallest);
        }
    }
}
