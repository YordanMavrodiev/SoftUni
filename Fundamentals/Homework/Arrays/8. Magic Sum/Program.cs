using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < read.Length; i++)
            {
                for (int j = i+1; j < read.Length; j++)
                {
                    if (read[i]+read[j]==a)
                    {
                        Console.WriteLine(read[i] +" "+ read[j]);
                        
                    }
                }
            }
        }
    }
}
