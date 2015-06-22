using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
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

            int result = N - K;
            long factorialNK = 1;
            for (int counter = 1; counter <= result; counter++)
            {
                factorialNK *= counter;
            }
            Console.WriteLine("(6 - 4)! = " + factorialNK);

            long finalresult = (factorialN * factorialK) / factorialNK;
            Console.WriteLine("6! * 4! / (6-4)! = " + finalresult);
        }
    }
}
