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
            int n = 3;
            int m = 4;
            int sum = 1;
            for (int i = 1; i <= m; i ++)
            {
                sum = sum * n; 
            }
            Console.WriteLine(sum);
        }
    }
}
