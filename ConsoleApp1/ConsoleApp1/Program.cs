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
            int[] intArray01 = new int[] { 18, 42, 55, 44, 26 };
            int loopCounter;

            for(loopCounter = 0; loopCounter < intArray01.Length; loopCounter = loopCounter + 1)
            {
                Console.WriteLine("intArray01[{0}] = {1}", loopCounter, intArray01[loopCounter]);
            }
            Console.WriteLine("Now in reverse");
            for(loopCounter = intArray01.Length -1; loopCounter >= 0; loopCounter--)
            {
                Console.WriteLine("intArray01[{0}] = {1}", loopCounter, intArray01[loopCounter]);
            }
            Console.ReadKey();
        }
    }
}
