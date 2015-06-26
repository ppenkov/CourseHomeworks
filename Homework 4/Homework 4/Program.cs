using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] N = new int [5];
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }
                int sum = 0;
            for (int i = 0; i < N.Length; i++)
			{
                if (N[i] % 2 == 0)
                {
                    sum = sum + N[i];
                }
            } 
                    Console.WriteLine(sum);
            }
        }
    }

