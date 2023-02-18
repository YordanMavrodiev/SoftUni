using System;

namespace _2._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            Array.ForEach(names, x => Console.WriteLine("Sir "+x));
        }
    }
}
