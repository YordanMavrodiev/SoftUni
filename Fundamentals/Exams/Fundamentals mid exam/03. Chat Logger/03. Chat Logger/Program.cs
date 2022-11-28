using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] enter = Console.ReadLine().Split(' ').ToArray();
            List<string> chat = new List<string>();
            while (enter[0]!="end")
            {
                if (enter[0]=="Chat")
                {
                    chat.Add(enter[1]);
                }
                else if (enter[0] == "Delete")
                {
                    if (chat.Contains(enter[1]))
                    {
                        chat.Remove(enter[1]);
                    }
                    
                }
                else if (enter[0] == "Edit")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (chat[i]==enter[1])
                        {
                            chat[i] = enter[2];
                            break;
                        }
                    }
                }
                else if (enter[0] == "Pin")
                {
                    if (chat.Contains(enter[1]))
                    {
                        chat.Remove(enter[1]);
                        chat.Add(enter[1]);
                    }
                }
                else if (enter[0] == "Spam")
                {
                    for (int i = 1; i < enter.Length; i++)
                    {
                        chat.Add(enter[i]);
                    }
                }
                enter = Console.ReadLine().Split(' ').ToArray();
            }
            for (int i = 0; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
