using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double result = Sum(a) / Sum(b);
            Console.WriteLine(result.ToString("F2"));
        }
        static double Sum(double a)
        {
            double factorial = 1;
            for (double i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
    }
}
