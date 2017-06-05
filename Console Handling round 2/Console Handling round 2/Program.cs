using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Handling_round_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // tryparse method on int32 to show how it works
            string s1 = "123";
            int int01 = 0;
            bool status = false;
            Console.WriteLine("s1 contains {0}, int01 is {1}, and status is {2}", s1, int01, status);
            status = Int32.TryParse(s1, out int01);
            Console.WriteLine("s1 contains {0}, int01 is {1}, and status is {2}", s1, int01, status);
            Console.ReadKey();

            // adding integers from console input exercise
            // variables to hold the numbers in string format
            string sInt01;
            string sInt02;
            // variables to hold the converted integers in from tryparse
            int iInt01;
            int iInt02;
            // variable to hold the total result in from adding the integers
            int iTotal;

            // booleans used to store status of successful conversion from tryparse
            bool bSuccessfulConversion01 = false;
            bool bSuccessfulConversion02 = false;

            // Console dialog and text entry prompts with variables assigned to hold values entered
            Console.Write("Please enter the first integer: ");
            sInt01 = Console.ReadLine();
            Console.Write("Please enter the second integer: ");
            sInt02 = Console.ReadLine();

            // tryparse is ran on each integer entered to return a bool and to assign
            // the new integer to a variable. 
            bSuccessfulConversion01 = Int32.TryParse(sInt01, out iInt01);
            bSuccessfulConversion02 = Int32.TryParse(sInt02, out iInt02);


            //Simple if logic to test and make sure the values entered were integers
            // and that conversion occured
            // refactored to always tell you which input was not an integer.
            //
            if ((bSuccessfulConversion01 == false) && (bSuccessfulConversion02 == false))
            {
                Console.WriteLine("Both entries are not integers");
            }
            else if (bSuccessfulConversion01 == false && bSuccessfulConversion02 == true)
            {
                Console.WriteLine("The first entry is not an integer but the second entry is.");
            }
            else if (bSuccessfulConversion01 == true && bSuccessfulConversion02 == false)
            {
                Console.WriteLine("The first entry is an integer but the second entry is not.");
            }
            else // else statement to combine the two integers and print out the result
            {
                iTotal = iInt01 + iInt02;
                Console.WriteLine("Both are integers. The sum is {0}", iTotal);
            }
            Console.ReadKey(); // exits program on button press
        }
    }
}
