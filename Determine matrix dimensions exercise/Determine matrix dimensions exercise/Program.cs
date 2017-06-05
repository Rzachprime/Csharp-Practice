using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determine_matrix_dimensions_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // tells the length and width of a 2 dimensional array
            int[,] matrix1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int rank = matrix1.Rank;
            for(int k = 0; k < rank; k++)
            {
                int length = matrix1.GetLength(k);
                Console.WriteLine("Length of dimension {0} = {1}", k, matrix1.GetLength(k));
            }


            int a, b;
            // writes out matrix as it looks on a grid
            for(a = 0; a < matrix1.GetLength(0); a++)
            {
                for(b = 0; b < matrix1.GetLength(1); b++)
                {
                    Console.Write(" {0} ", matrix1[a, b]);//writes out matrix line using a and b as the positions
                }
                Console.WriteLine();
            }
            // my own code to print out the position in the array's index of a a value
            for (a = 0; a < matrix1.GetLength(0); a++)
            {
                for (b = 0; b < matrix1.GetLength(1); b++)
                    Console.WriteLine("matrix1 Value {0} equals the index value [{1},{2}] in the array", matrix1[a, b], a, b);
            }
            // adding matrixes together exercise
            // use original matrix and add a second one to it.
            int[,] matrix2 = new int[,] { { 5, 5, 8 }, { 3, 1, 3 } };
            int[,] resultMatrix = new int[2, 3];

            for (a = 0; a < matrix1.GetLength(0); a++)
            {
                for(b = 0; b < matrix1.GetLength(1); b++)
                {
                    resultMatrix[a, b] = matrix1[a, b] + matrix2[a, b];
                    Console.Write(" {0} ", resultMatrix[a, b]);
                }
                Console.WriteLine();
            }
            // print out patterns exercise using loops
            string[] patternArray = new string[] { "o", "oo", "ooo", "oooo", "ooooo", "oooooo", "ooooooo", "oooooooo" };

            int maxLength = 0;

            foreach (string s in patternArray)
            {
                if (s.Length > maxLength) maxLength = s.Length;
            }

            int fieldwidth = maxLength;
            for (int i = 0; i < patternArray.Length; i++) 
            {
                string formatStr = "{0,-" + fieldwidth + "}" + "{0," + fieldwidth + "}";
                string outputStr = String.Format(formatStr, patternArray[i]);
                Console.WriteLine(outputStr);
            }

            for(int i = (patternArray.Length -2); i >= 0; i--)
            {
                string formatStr = "{0,-" + fieldwidth + "}" + "{0," + fieldwidth + "}";
                string outputStr = String.Format(formatStr, patternArray[i]);
                Console.WriteLine(outputStr);
            }
            Console.ReadKey();
        }
    }
}
