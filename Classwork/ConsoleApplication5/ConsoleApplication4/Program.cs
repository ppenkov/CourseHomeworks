using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[] { 1, 2, 3, 4, 5 };
            bool issymetric = true;

            for (int i = 0; i < N.Length / 2; i++)
            {
                if (N[1] !=  N[N.Length - 1 - i]);
                {
                    issymetric = false;
                break;
                }
            }
                Console.WriteLine("The Array is symetric:" + issymetric);
            }
    }
}
