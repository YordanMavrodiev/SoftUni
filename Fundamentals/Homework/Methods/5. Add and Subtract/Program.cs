using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Sum(a,b),c));

        }
        static int Sum(int a, int b)
        {
            int kekw = a + b;
            return kekw;

        }
        static int Subtract(int sum, int c)
        {
            int kekw = sum-c;
            return kekw;

        }
    }
}
