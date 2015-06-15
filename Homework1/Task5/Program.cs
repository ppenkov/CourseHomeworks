using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете текст или число:");
            string m = Console.ReadLine();
            Console.WriteLine("Въведете различен текст или число:");
            string n = Console.ReadLine();
            string result = (m + "_" + n);
            Console.WriteLine("Резултат:" + result);
        }
    }
}
