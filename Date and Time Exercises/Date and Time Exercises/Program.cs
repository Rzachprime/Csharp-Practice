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
            // utc date time format
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine("The current utc date and time are {0}", currentDateTimeUTC);
            // difference in time between time zones
            TimeSpan timeDiff = currentDateTime.Subtract(currentDateTimeUTC);
            Console.WriteLine("The difference in time is {0} hours and {1} minutes", timeDiff.Hours, timeDiff.Minutes);
            if((Math.Sign(timeDiff.Hours)== -1) || (Math.Sign(timeDiff.Minutes)== -1))
            {
                Console.WriteLine("My current timezone is behind UTC");
            }
            else if (((timeDiff.Hours) == 0)&& (timeDiff.Minutes == 0))
            {
                Console.WriteLine("My current timezone is UTC");

            }
            else
            {
                Console.WriteLine("My current timezone is ahead of UTC");
            }
            Console.ReadKey();
        }
    }
}
