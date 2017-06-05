using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cArray01 = new char[] { 'A', 'B', 'C', 'D', 'E' };
            for(int j = 0; j < cArray01.Length; j++)
            {
                for(int k = 1; k <=10; k++)
                {
                    String sf01 = String.Format("{0}{1}", cArray01[j], k);
                    if (sf01.Equals("C5") == true) break;
                    Console.Write(sf01); Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
