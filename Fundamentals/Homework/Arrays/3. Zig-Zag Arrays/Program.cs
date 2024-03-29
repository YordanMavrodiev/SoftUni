﻿using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int[] read = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    array1[i] = read[0];
                    array2[i] = read[1];
                }
                else 
                {
                    array1[i] = read[1];
                    array2[i] = read[0];
                }
                
            }
            Console.WriteLine(string.Join(" ",array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
