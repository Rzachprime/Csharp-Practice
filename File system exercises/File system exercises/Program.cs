using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_system_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir01 = Directory.GetCurrentDirectory();
            string dir02 = Environment.CurrentDirectory;
            Console.WriteLine(dir01);
            Console.WriteLine(dir02);
            Console.ReadKey();
        }
    }
}
