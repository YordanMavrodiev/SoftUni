using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            
            for (int i = 0; i < read.Length; i++)
            {
                if (read.Length <= 1)
                {
                    Console.WriteLine(0);
                    break;
                }
                sum1 = 0;
                
                for (int j = 0; j < i; j++)
                {
                    sum1 += read[j];
                    
                }
                sum2 = 0;
                for (int k = i+1; k < read.Length; k++)
                {
                    sum2 += read[k];
                }
                if (sum1==sum2)
                {
                    Console.WriteLine(i);
                    break;
                }
                
            }
            Console.WriteLine("no");
           
                
            
            
        }
    }
}
