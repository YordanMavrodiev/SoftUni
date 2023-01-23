using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            char[,] matrix = new char[rowCol[0], rowCol[1]];
            int x = 0;
            for (int rows = 0; rows < rowCol[0]; rows++)
            {
                if (rows% 2 == 0)
                    {
                        for (int cols = 0; cols < rowCol[1]; cols++)
                        {
                        if (x == snake.Length)
                        {
                            x = 0;
                        }
                        matrix[rows, cols] = snake[x];
                        x++;
                        }
                    }
                else 
                {
                        for (int cols = rowCol[1]-1; cols >= 0; cols--)
                        {
                        if (x == snake.Length)
                        {
                            x = 0;
                        }
                        matrix[rows, cols] = snake[x];
                        x++;
                        }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
