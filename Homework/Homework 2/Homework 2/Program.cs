using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a position from 0 to 9:");
            int Standings = int.Parse(Console.ReadLine());
            switch (Standings)
            {
                case 0:
                    Console.WriteLine("Non available position");break;
                case 1:
                    Console.WriteLine("Team: Chelsea");break;
                case 2:
                    Console.WriteLine("Team: Manchester City");break;
                case 3:
                    Console.WriteLine("Team: Arsenal");break;
                case 4:
                    Console.WriteLine("Team Manchester United");break;
                case 5:
                    Console.WriteLine("Team: Tottenham Hotspur");break;
                case 6:
                    Console.WriteLine("Team: Liverpool");break;
                case 7:
                    Console.WriteLine("Team: Sothampton");break;
                case 8:
                    Console.WriteLine("Team: Swansea");break;
                case 9:
                    Console.WriteLine("Team: Stoke City");break;
            }
        }
    }
}