using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();
            int Push = commands[0];
            int Pop = commands[1];
            int number = commands[2];
            for (int i = 0; i < Push; i++)
            {
                stack.Push(elements[i]);
            }
            for (int i = 0; i < Pop; i++)
            {
                stack.Pop();
                
            }
            if (stack.Contains(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min()); 
                }
                else Console.WriteLine(0);
            }
            

        }
    }
}
