using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,]matrix= new int[n,n];
            for (int rows = 0; rows < n; rows++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = data[cols];
                }
            }
            int sumprim = 0;
            int sumsec = 0;
            for (int rows = 0; rows < n; rows++)
            {
                

                sumprim+=matrix[rows, rows];
            }
            int colums = n-1;
            for (int rows = 0; rows < n; rows++)
            {

             sumsec+=matrix[rows, colums];
                colums--;
                
            }
            int sum = sumprim - sumsec;
            Console.WriteLine(Math.Abs(sum));
        }
    }
}
