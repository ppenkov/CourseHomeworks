using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете произволно число:");
            decimal z = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведете цяло число:");
            long w = long.Parse(Console.ReadLine());
            Console.WriteLine("Резултат от делението:" + (z / w));
        }
    }
}
