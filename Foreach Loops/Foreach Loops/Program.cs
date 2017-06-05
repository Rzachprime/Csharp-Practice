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

            int index = 0;

            foreach (int dude in intArray01)
            {
                Console.WriteLine("{0}", dude);
            }
            // Second exercise starts here. Writing out array and listing its index number
            Console.WriteLine("Second exercise below");
            foreach(int star in intArray01)
            {
                Console.WriteLine("intArray01[{0}] = {1}", index, star);
                index++;
            }
            // third exercise starts here. Writing out array in reverse. Not the best solution
            // for a better option try copying the array to a new variable and reversing the copy
            // instead of the original
            Console.WriteLine("Reverse exercise below");
            Array.Reverse(intArray01);
            index = 0;
            foreach(int arrayValue in intArray01)
            {
                Console.WriteLine("intArray01[{0}] = {1}", index, arrayValue);
                index++;
            }
            // fourth exerecise starts here. Printing out even index values only. Note that
            // zero is considered even. Also had to reverse the array again to fix it.
            Console.WriteLine("Print out even index exercise below");
            index = 0;
            Array.Reverse(intArray01);
            foreach(int arrayItem in intArray01)
            {
                if(index % 2 == 0)
                {
                    Console.WriteLine("intArray01[{0}] = {1}", index, arrayItem);
                }
                index++;
            }
            // fifth exercise below. Repeat exercise four using a for loop instead
            // note the lack of curly braces for the code that will execute. 
            // also note that you can skip using an if statement by simply
            // forcing the program to incrase the counter with alternative logic
            // by skipping the odd numbers with the add to self operator.
            Console.WriteLine("For loop version of above exercise");
            for (int j = 0; j < intArray01.Length; j += 2)
                Console.WriteLine("intArray[{0}] = {1}", j, intArray01[j]);
            //Now doing the same with a while loop
            Console.WriteLine("While loop even exercise below");
            int counter = 0;
            int arrayLength = intArray01.Length -1;
            while (counter <= arrayLength)
            {
                Console.WriteLine("intArray01[{0}] = {1}", counter, intArray01[counter]);
                counter = counter + 2;
            }
            Console.ReadKey();
        }
    }
}
