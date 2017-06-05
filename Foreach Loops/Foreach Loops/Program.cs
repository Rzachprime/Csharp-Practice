using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray01 = new int[] { 18, 42, 26, 44, 55 };

            foreach (int dude in intArray01)
            {
                Console.WriteLine("{0}", dude);
            }
            Console.ReadKey();
        }
    }
}
