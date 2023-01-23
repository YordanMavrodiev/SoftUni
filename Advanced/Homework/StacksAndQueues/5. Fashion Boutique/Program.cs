using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < list.Count; i++)
            {
                queue.Enqueue(list[i]);
            }
            for (int i = 0; i < list.Count; i++)
            {
                sum += queue.Peek();
                if (capacity >= sum)
                {
                    queue.Dequeue();
                }
                else 
                { 
                racks++;
                sum = queue.Dequeue();
                }
            }
            Console.WriteLine(racks.ToString());
        }
    }
}
