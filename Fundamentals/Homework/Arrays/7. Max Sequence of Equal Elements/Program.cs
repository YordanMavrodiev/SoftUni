using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] read = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int count = 0;
            int thenumber = 0;
            int maxcount = 0;
            for (int i = 0; i < read.Length-1; i++)
            {
                if (read[i] == read[i + 1])
                {
                    count++;
                }
                else count = 0;
                if (count>maxcount)
                {
                    maxcount = count;
                    thenumber = read[i];
                }
            }
            for (int i = 0; i <= maxcount; i++)
            {
                Console.Write(thenumber+" ");
            }
        }
    }
}
