using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int>evenNumberTimes=new Dictionary<int,int>();
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenNumberTimes.ContainsKey(number)) 
                {
                    evenNumberTimes.Add(number, 1);
                    
                }
                else evenNumberTimes[number] ++;
            }
            foreach (var number in evenNumberTimes)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
