using System;
using System.Numerics;


namespace Try_Parse_Exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputBool;
            short inputInt16;
            int inputInt32;
            long inputInt64;
            float inputFloat;
            double inputDouple;
            decimal inputDecimal;
            BigInteger inputBigInt;

            while (true)
            {
                Console.Write("Enter any integer, float, double, BigInt, boolean, or string item: ");
                string sInput = Console.ReadLine();
                sInput = sInput.ToLower();
                if (sInput.Equals("quit")) break;
                if (Boolean.TryParse(sInput, out inputBool))
                    Console.WriteLine("You entered a Boolean");
                else if (Int16.TryParse(sInput, out inputInt16))
                    Console.WriteLine("You entered a short integer");
                else if (Int32.TryParse(sInput, out inputInt32))
                    Console.WriteLine("You entered an integer (4 bytes)");
                else if (long.TryParse(sInput, out inputInt64))
                    Console.WriteLine("You entered a long integer");
                else if (BigInteger.TryParse(sInput, out inputBigInt))
                    Console.WriteLine("You entered a Big Integer");
                else if (float.TryParse(sInput, out inputFloat))
                    Console.WriteLine("You entered a float");
                else if (double.TryParse(sInput, out inputDouple))
                    Console.WriteLine("You entered a double");
                else if (Decimal.TryParse(sInput, out inputDecimal))
                    Console.WriteLine("You entered a decimal");
                else
                    Console.WriteLine("You entered a string");
                

            }
            Console.ReadKey();
        }
    }
}
