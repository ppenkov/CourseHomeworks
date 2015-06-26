using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете второ число:");
            int y = int.Parse(Console.ReadLine());
            int result = x + y;
            Console.WriteLine("Сбор:"+result);
        }
    }
}
