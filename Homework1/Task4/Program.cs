using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете цяло число:");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете второ цяло число:");
            long b = long.Parse(Console.ReadLine());
            long result = a % b;
            Console.WriteLine("Остатък от деление на числата:" + result);
        }
    }
}