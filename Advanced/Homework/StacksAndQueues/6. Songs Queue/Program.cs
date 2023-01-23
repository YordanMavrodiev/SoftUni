using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < songs.Count; i++)
            {
                queue.Enqueue(songs[i]);
            }
            while (queue.Any())
            {
                List<string> command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", command.Skip(1));
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else queue.Enqueue(song);


                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",queue));

                        break;
                    


                }
            } 
                
            
            Console.WriteLine("No more songs!");
        }
    }
}
