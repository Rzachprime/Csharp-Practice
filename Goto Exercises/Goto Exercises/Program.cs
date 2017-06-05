using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cArray01 = { 'A', 'B', 'C' };
            // My answer to the Goto Exercise
            for (int i = 0; i < cArray01.Length; i++)
            {
                for(int k = 1; k <= 10; k++)
                {
                    if (i == 2 && k == 5) goto my_breakout_point;
                    Console.Write("{0}{1} ", cArray01[i], k);
                }
                Console.WriteLine();
            }
            my_breakout_point: Console.WriteLine("\nJUST SAW A C5!!!!");

            //Text book answer to the GOTO exercise
            for(int j = 0; j < cArray01.Length; j++)
            {
                for(int l = 1; l <= 10; l++)
                {
                    string sf01 = String.Format("{0}{1}", cArray01[j], l);
                    if (sf01.Equals("C5") == true) goto my_breakout_point2;
                    Console.Write(sf01); Console.Write(" ");
                }
                Console.WriteLine();
            }
            my_breakout_point2: Console.WriteLine("\nJust saw a C5");
            Console.ReadKey();
        }
    }
}
