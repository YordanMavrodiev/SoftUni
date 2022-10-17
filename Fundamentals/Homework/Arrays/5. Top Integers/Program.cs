using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] read = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            for (int i = 0; i < read.Length; i++)
            {
                bool isItBigger = true;
                for (int j = i+1; j < read.Length; j++)
                {
                    if (read[i] <= read[j])
                    {
                        isItBigger = false;

                    }
                }
                if (isItBigger)
                {
                    Console.Write(read[i]+" ");
                }
                
            }

           


        }
    }
}
