using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            string[] word = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            while (word[0]!="end")
            {
                if (word[0]=="Add")
                {
                    items.Add(int.Parse(word[1]));
                }
                if (int.TryParse(word[0],out int a))
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i]+int.Parse(word[0])<=max)
                        {
                            int b = items[i] + int.Parse(word[0]);
                            items[i] = b;
                            break;
                        }
                    }
                }
                word= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            }
            Console.WriteLine(string.Join(" ",items));

        }
    }
}
