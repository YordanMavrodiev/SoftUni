using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            if ((int)b>(int)a)
            {
                char m = b;
                b = a;
                a = m;
            }
            for (int i = (int)b+1; i < (int)a; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
