using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic program to convert temperatures
            Console.Write("enter temperature: ");
            string sInput = Console.ReadLine();
            string tempScale;

            sInput = sInput.ToLower();

            if (sInput.Contains("f"))
                tempScale = "f";
            else if (sInput.Contains("c"))
                tempScale = "c";
            else
            {
                Console.WriteLine("You have to specify C or F");
                Console.ReadKey();
                return;
            }
            sInput = sInput.Replace("f", "");
            sInput = sInput.Replace("c", "");

            double d01;
            if (!(Double.TryParse(sInput, out d01)))
            {
                Console.WriteLine("What you entered was not a valid number");
                Console.ReadKey();
                return;
            }
            if (tempScale.Equals("f"))
            {
                Console.WriteLine("Equivalent temp = {0}C", (d01 - 32) * ((float)5 / (float)9));
            }
            else
                Console.WriteLine("Equivalent temp = {0}F", (d01 * (float)9 / (float)5) + 32);
            Console.ReadKey();
        }
    }
}
