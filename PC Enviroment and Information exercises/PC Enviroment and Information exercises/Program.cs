using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Enviroment_and_Information_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string myDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(myDesktop);
            Console.ReadKey();

            DriveInfo[] driveList = DriveInfo.GetDrives();
            int numberOfDrives = driveList.Length;
            int index = numberOfDrives;

            Console.WriteLine("The number of drives in this computer = {0}", numberOfDrives);

            while (index > 0)
            {
                index--;
                Console.WriteLine("Drive name: {0}", driveList[index].Name);
            }
            Console.ReadKey();
        }
    }
}
