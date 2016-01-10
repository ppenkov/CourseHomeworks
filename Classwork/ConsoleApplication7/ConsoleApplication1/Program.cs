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
            int a = 10;
            int b = 11;

            int c = Sum(a, b);
         
            Console.WriteLine(c);
        }

        private static int Sum(int a, int b)
        {
            int Sum2 = a + b;
            return Sum2;
        }
    }
}
