using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете произволен текст или число:");
            string r = Console.ReadLine();
            string p = r.Substring(0,1);
            Console.WriteLine("Резултат:" + p);
        }
    }
}
