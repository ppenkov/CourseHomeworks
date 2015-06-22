using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 6;
            long factorialN = 1;
            for (int counter = 1; counter <= N; counter++)
            {
                factorialN *= counter;
            }
            Console.WriteLine("{0}! = {1}", N, factorialN);

            int K = 4;
            long factorialK = 1;
            for (int counter = 1; counter <= K; counter++)
            {
                factorialK *= counter;
            }
            Console.WriteLine("{0}! = {1}", K, factorialK);

            long result = (factorialN / factorialK);
            Console.WriteLine(result);
        }
    }
}
