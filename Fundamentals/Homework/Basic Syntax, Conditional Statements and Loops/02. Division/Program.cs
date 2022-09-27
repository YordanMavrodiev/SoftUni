using System;
using System.Collections.Generic;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<int> list = new List<int>() { 10, 7, 6, 3, 2 };
            int devision = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (a % list[i] == 0)
                {
                    devision = list[i];
                    break;
                }
            }
            if (devision != 0)
            {
                Console.WriteLine("The number is divisible by " + devision);
            }
            else Console.WriteLine("Not divisible");
        }
    }
}
