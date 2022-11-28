using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] word = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (word[0] != "end")
            {
                if (word[0] == "Delete")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i]==int.Parse(word[1]))
                        {
                            items.RemoveAt(i);
                        }
                    }
                }
                if (word[0] == "Insert")
                {
                    items.Insert(int.Parse(word[2]), int.Parse(word[1]));
                }
                word = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
