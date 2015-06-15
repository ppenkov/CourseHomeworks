using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете произволен текст или число:");
            string r = Console.ReadLine();
            Console.WriteLine("Въведете различен текст или число:");
            string t = Console.ReadLine();
            long result = r.IndexOf(t);
            Console.WriteLine("Резултат:" + result);
        }
    }
}
