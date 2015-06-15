using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете дължината на страна А на триъгълника:");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Въведете дължината на височината на триъгълника");
            long h = long.Parse(Console.ReadLine());
            long result = a * h;
            Console.WriteLine("Лице на триъгълника:" + result);
        }
    }
}
