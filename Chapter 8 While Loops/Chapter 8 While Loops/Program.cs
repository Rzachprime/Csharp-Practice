using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray01 = new int[] { 18, 42, 26, 44, 55 };

            int loopCounter = intArray01.Length - 1;

            while (loopCounter >= 0)
            {
                Console.WriteLine("intArray01[{0}] = {1}", loopCounter, intArray01[loopCounter]);
                loopCounter = loopCounter - 1;
            }
            Console.ReadKey();

        }
    }
}

