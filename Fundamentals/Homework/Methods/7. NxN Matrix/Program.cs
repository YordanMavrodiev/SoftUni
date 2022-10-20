using System;

namespace _7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Matrix(a);
        }
        static void Matrix(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(a+" ");
                }
                Console.WriteLine();
            }
            

        }
    }
}
