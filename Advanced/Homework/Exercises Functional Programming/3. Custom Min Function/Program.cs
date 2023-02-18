using System;
using System.Linq;

namespace _3._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> func = (x) => 
            {
                int min = int.MaxValue;
                foreach (var item in x)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;

            };
            Console.WriteLine(func(numbers));
        }
    }
}
