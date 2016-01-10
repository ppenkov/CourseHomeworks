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
            string[] gosho = new string[] { "We", "Are", "The", "Champions" };
            foreach  (string element in gosho)
            {
                Console.WriteLine(element); 
            }    
        }
    }
}
