using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[] { 1, 2, 3, 4, 5 };
           
        
            for (int i = 0; i < N.Length / 2; i++)
            {
                int temp = N[i];
                N[i] = N[N.Length - 1 - i];
                N[N.Length - 1 - i] = temp;
            }
            foreach  (int element in N)
            {
                Console.WriteLine(element);
            }
        }
    }
}
