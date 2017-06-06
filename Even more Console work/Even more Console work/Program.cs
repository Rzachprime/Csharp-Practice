using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_more_Console_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of args={0}", args.Length);
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("argument[{0}] = 1", i, args);

            }

            if (args.Length != 2)
            {
                Console.WriteLine("Please pass exactly two arrguments");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("{0}, {1}", args[1], args[0]);


            Console.ReadKey();
        }


    }
}
