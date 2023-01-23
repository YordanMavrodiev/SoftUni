using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var chemicals = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split();
                foreach (var compound in compounds)
                {
                    chemicals.Add(compound);



                }


            }
            chemicals = chemicals.OrderBy(x => x).ToHashSet();
            Console.WriteLine(String.Join(" ",chemicals));
        }
    }
}
