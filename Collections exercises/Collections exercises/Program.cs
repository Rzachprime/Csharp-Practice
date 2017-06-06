using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList01 = new List<int>() { 10, 20, 30, 40 };

            // new list string object
            List<string> stringList01 = new List<string>();

            stringList01.Add("Mary");
            stringList01.Add("had");
            stringList01.Add("a");
            stringList01.Add("little");
            stringList01.Add("lamb");
            stringList01.Add("little");
            stringList01.Add("lamb");
            stringList01.Add("little");
            stringList01.Add("lamb");

            // count how many elements are in the list
            int listLength = stringList01.Count;

            Console.WriteLine("There are {0} items in the list", listLength);

            // print out the 4th element of the string list
            Console.WriteLine("The fourth item is {0}", stringList01[3]);

            // print out the list capacity
            int listCapacity = stringList01.Capacity;
            Console.WriteLine("The list capacity is {0}", listCapacity);

            //print out the list

            for(int j = 0; j < stringList01.Count; j++)
            {
                Console.WriteLine(stringList01[j]);
            }

            // copy the list to an array and print it out

            string[] stringArray01 = new string[listLength];
            stringList01.CopyTo(stringArray01);

            for (int k = 0; k < stringArray01.Length; k++)
            {
                Console.WriteLine("Array item {0} = {1}", k, stringList01[k]);
            }

            // modify the string output to change the rhyme.
            stringList01.Insert(1, "didn't");

            stringList01.RemoveAt(2);
            stringList01.Insert(2, "have");

            foreach (string item in stringList01)
                Console.WriteLine("{0} ", item);

            // sort the list
            stringList01.Sort();

            foreach (string item in stringList01)
                Console.WriteLine("{0} ", item);



            Console.ReadKey();
        }
    }
}
