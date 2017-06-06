using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int? int01 = null;

            if (int01.HasValue)
            {
                Console.WriteLine("int01 has a value of {0}", int01);
            }
            else
                Console.WriteLine("int01 is currently unassigned");
            bool value01 = int01.HasValue;

            Console.WriteLine("{0}", value01);
            Console.ReadKey();
        }
    }
}
