using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            Array.ForEach(names, x => Console.WriteLine(x));
        }
    }
}
