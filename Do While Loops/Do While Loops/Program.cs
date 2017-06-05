using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double iNumToCalculateFactorial = 10;

            long result = 1;
            int index = 1;
            do
            {
                result = result * index;
                index++;
            } while (index <= iNumToCalculateFactorial);

            Console.WriteLine("{0}! = {1}", iNumToCalculateFactorial, result);
            
            //Wrote my own do while loop to test the logic out.
            Console.WriteLine("My own do while loop is below. Beware of Bob!");
            int bob = 0;
            int counter = 0;
            do
            {
                bob = bob + 1;
                counter = bob;
                Console.WriteLine("Bob has multiplied again. There are {0} Bob clones now!", counter);
            } while (counter < 10);
            Console.ReadKey();
        }
    }
}
