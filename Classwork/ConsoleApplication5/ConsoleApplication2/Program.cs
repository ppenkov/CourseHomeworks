using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[] { 1, 2, 3, 4, 5 };

            int[] K = new int[5];

            for (int i = 0; i < N.Length; i++)
            {
                K[i] = N[i];
            }
            foreach (int L in K)
            {
                Console.WriteLine(L);
            }

        }
    }
}
