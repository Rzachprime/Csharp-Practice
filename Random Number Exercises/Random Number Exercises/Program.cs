using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random01 = new Random();

            for (int count = 0; count < 10; count++)
            {
                int value = random01.Next();
                Console.WriteLine("The next random number is {0}", value);
            }
            Console.ReadKey();
            int seed = 250;

            Random random0 = new Random(seed);

            for(int count = 0; count < 10; count++)
            {
                int value = random0.Next();
                Console.WriteLine("The next random number is {0}", value);
            }
            Console.ReadKey();

            Random random03 = new Random();
            int die01 = random03.Next(1, 6);
            int die02 = random03.Next(1, 6);

            Console.WriteLine("The value of the 1st die is {0} and the value of the 2cnd is {1}", die01, die02);
            Console.ReadKey();
        }
    }
}
