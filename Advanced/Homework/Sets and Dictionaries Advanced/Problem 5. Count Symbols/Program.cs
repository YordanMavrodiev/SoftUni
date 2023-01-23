using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = (Console.ReadLine());
            Dictionary<char, int> evenNumberTimes = new Dictionary<char, int>();

            for (int i = 0; i < n.Length; i++)
            {

                if (!evenNumberTimes.ContainsKey(n[i]))
                {
                    evenNumberTimes.Add(n[i], 1);

                }
                else evenNumberTimes[n[i]]++;
            }
            evenNumberTimes = evenNumberTimes.OrderBy(x => x.Key).ToDictionary(x => x.Key,x=>x.Value);
            foreach (var number in evenNumberTimes)
            {
                Console.WriteLine($"{number.Key}: {number.Value} time/s");
            }
        }
    }
}
