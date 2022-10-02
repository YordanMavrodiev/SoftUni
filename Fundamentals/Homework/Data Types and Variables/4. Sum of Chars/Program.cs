using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum += (int)character;
            }
            Console.WriteLine("The sum equals: "+sum);
        }
    }
}
