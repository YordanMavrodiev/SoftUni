using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallest(a, b, c);
        }
        static void PrintSmallest(int a, int b, int c)
        {
            int min = 0;
            if (a <= b && a <= c)
            {
                min = a;
            }
            if (a >= c && b >= c)
            {
                min = c;
            }
            if (a >= b && b <= c)
            {
                min = b;
            }
            Console.WriteLine(min);
        
        }
    }
}
