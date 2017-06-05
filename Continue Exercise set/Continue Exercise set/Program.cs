using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Exercise_set
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i == 1001) break;
                if (i % 5 == 0) continue;
                Console.WriteLine(i) ;
            }
            Console.ReadKey();
        }
    }
}
