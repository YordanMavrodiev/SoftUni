using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex rgx = new Regex(@"(\!)(?<Name>[A-Z][a-z]{2,})\1:(\[)(?<Word>[A-Za-z]{8,})(\])");
                
                if (rgx.IsMatch(input))
                {
                    
                    Match match = rgx.Match(input);
                    string command = match.Groups["Name"].Value;
                    string name = match.Groups["Word"].Value;
                    List<int> thename = new List<int>();
                    for (int j = 0; j < name.Length; j++)
                    {
                        thename.Add((int)name[j]);
                    }
                    Console.WriteLine(command+": "+string.Join(" ",thename));

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}
