using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < list.Count; i++)
            {
                queue.Enqueue(list[i]);
            }
            int max = queue.Max();
            for (int i = 0; i < list.Count; i++)
            {
                if (quantity >= queue.Peek())
                {
                    quantity -= queue.Peek();
                    queue.Dequeue();
                    


                }
            }
            Console.WriteLine(max);
            if (queue.Count>0)
            {
                
                Console.WriteLine("Orders left: " + String.Join(" ", queue));
                
            }
            else Console.WriteLine("Orders complete"); 

        }
    }
}
