using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                
                if (sum + litres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");

                }
                else sum += litres;
                
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
