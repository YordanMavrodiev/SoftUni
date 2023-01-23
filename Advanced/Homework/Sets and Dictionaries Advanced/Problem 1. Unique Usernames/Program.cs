using System;
using System.Collections.Generic;

namespace Problem_1._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string name=Console.ReadLine(); 
                if (!names.Contains(name))
                {
                    names.Add(name);
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
