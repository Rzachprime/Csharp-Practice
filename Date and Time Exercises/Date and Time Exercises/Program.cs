using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date & time is now {0}", currentDateTime);
            Console.ReadKey();
        }
    }
}
