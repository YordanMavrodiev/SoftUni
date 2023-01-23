using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            var nset = new HashSet<int>();
            var mset = new HashSet<int>();
            var end = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int numberN = int.Parse(Console.ReadLine());
                
                    nset.Add(numberN);
                
            }
            for (int i = 0; i < m; i++)
            {
                int numberM = int.Parse(Console.ReadLine());

                mset.Add(numberM);

            }
            foreach (var number in nset)
            {
                if (mset.Contains(number))
                {
                    
                    end.Add(number);
                }
            }
            Console.WriteLine(String.Join(" ",end));
            
        }
    }
}
