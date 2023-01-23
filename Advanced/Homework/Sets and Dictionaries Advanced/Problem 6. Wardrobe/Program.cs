using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse (Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> evenNumberTimes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] cloth = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (!evenNumberTimes.ContainsKey(cloth[0]))
                {
                    evenNumberTimes[cloth[0]] = new Dictionary<string, int>();

                }
                for (int j = 1; j < cloth.Length; j++)
                {
                    if (!evenNumberTimes[cloth[0]].ContainsKey(cloth[j]))
                    {
                        evenNumberTimes[cloth[0]].Add(cloth[j], 0);
                    }
                    evenNumberTimes[cloth[0]][cloth[j]]++;
                }
            }
            string[] thecloth=Console.ReadLine().Split();
            foreach (var color in evenNumberTimes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == thecloth[0] && item.Key == thecloth[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
        }
    }
}
