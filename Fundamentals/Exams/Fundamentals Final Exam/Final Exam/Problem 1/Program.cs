using System;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0]!="Finish")
            {
                switch (command[0])
                {
                    case "Replace":word = word.Replace(command[1], command[2]);
                        Console.WriteLine(word);
                        break;
                    case "Cut":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < word.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < word.Length)
                        {
                            int from = int.Parse(command[1]);
                            int count = int.Parse(command[2]) - int.Parse(command[1]);
                            word = word.Remove(from, count + 1);
                            Console.WriteLine(word);
                        
                        }
                        else Console.WriteLine("Invalid indices!");
                            break;
                    case "Make":
                        if (command[1]=="Upper")
                        {
                            word=word.ToUpper();
                        }
                        else if (command[1]=="Lower")
                        {
                           word= word.ToLower();
                        }
                        Console.WriteLine(word);
                        break;
                    case "Check":
                        if (word.Contains(command[1]))
                        {
                            Console.WriteLine($"Message contains {command[1]}");
                        }
                        else Console.WriteLine($"Message doesn't contain {command[1]}");
                        break;
                    case "Sum":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < word.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < word.Length)
                        {
                            int from = int.Parse(command[1]);
                            int  to = int.Parse(command[2]);
                            int sum = 0;
                            for (int i = from; i <= to; i++)
                            {
                                sum += (int)word[i];
                            }
                            Console.WriteLine(sum);

                        }
                        else Console.WriteLine("Invalid indices!");
                        break;
                }
                command=Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
