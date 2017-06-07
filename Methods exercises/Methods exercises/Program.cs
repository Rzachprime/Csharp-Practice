using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercises
{
    class Program
    {
        static void helloMethod() => WriteLine("Hello, how are you?");
       


        static void Main(string[] args)
        {
            helloMethod();
            Console.ReadKey();
        }
    }
}
