using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            for (int i = from; i <= to; i++)
            {
                char character = (char)i;
                Console.Write(character+" ");
                
            }
            
        }
    }
}
