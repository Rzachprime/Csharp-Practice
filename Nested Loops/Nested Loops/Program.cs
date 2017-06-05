using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, k;

            String[] letters = new String[] { "A", "B", "C", "D", "E" };

            for (j = 0; j < letters.Length; j++)
            {
                for(k =1; k < 5; k++)
                {
                    Console.Write("({0},{1})", letters[j], k);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
