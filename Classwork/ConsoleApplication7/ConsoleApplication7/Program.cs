using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 11;
            Sum(a, b);
        }

        private static void Sum(int a, int b)
        {
            Console.WriteLine("The result is:" + (a+b));
        }
     
    
    }
}
