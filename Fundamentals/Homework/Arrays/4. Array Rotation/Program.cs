using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

                while (read.Length < n)
            {
               
                n = n - read.Length;

                }
               
           
            int[] newarr = new int[read.Length];

            for (int i = 0; i < read.Length - n; i++)
            {
                newarr[i] = read[n + i];
                }
              
            int a = 0;
                for (int j = read.Length - n; j < read.Length; j++)
            {
                  
                newarr[j] = read[a];
                    a++;
             }


             Console.WriteLine(string.Join(" ", newarr));

        }
    }
}
