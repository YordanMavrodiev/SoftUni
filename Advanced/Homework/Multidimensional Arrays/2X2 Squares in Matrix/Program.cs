using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[rowCol[0], rowCol[1]];
            for (int rows = 0; rows < rowCol[0]; rows++)
            {
                var data= Console.ReadLine().Split(" ").ToArray();

                for (int cols = 0; cols < rowCol[1]; cols++)
                {
                    matrix[rows, cols] = data[cols];
                }
            }
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    string b = matrix[i + 1, j];
                    string c = matrix[i + 1, j + 1];
                    string d = matrix[i, j + 1];
                    string e = matrix[i, j];
                    if (b == c && c == d && d == e)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
