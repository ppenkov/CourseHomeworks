using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете произволна дума:");
            string x = Console.ReadLine();
            bool result = (x == "Hello");
            Console.WriteLine("Резултат:" + result);
        }
    }
}
