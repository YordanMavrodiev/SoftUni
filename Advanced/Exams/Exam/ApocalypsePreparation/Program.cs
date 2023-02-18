using System;
using System.Collections.Generic;
using System.Linq;

namespace ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] textiles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] medicaments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> tex = new Queue<int>();
            Stack<int> med = new Stack<int>();
            Dictionary<string, int> healItems = new Dictionary<string, int>();
            for (int i = 0; i < textiles.Length; i++)
            {
                tex.Enqueue(textiles[i]);
            }
            for (int i = 0; i < medicaments.Length; i++)
            {
                med.Push(medicaments[i]);
            }
            while (tex.Count > 0 && med.Count > 0)
            {
                int sum = tex.Peek() + med.Peek();
                if (sum == 30)
                {
                    if (!healItems.ContainsKey("Patch"))
                    {
                        healItems.Add("Patch", 0);
                    }
                    healItems["Patch"] += 1;
                    tex.Dequeue();
                    med.Pop();
                }
                else if (sum == 40)
                {
                    if (!healItems.ContainsKey("Bandage"))
                    {
                        healItems.Add("Bandage", 0);
                    }
                    healItems["Bandage"] += 1;
                    tex.Dequeue();
                    med.Pop();

                }
                else if (sum == 100)
                {
                    if (!healItems.ContainsKey("MedKit"))
                    {
                        healItems.Add("MedKit", 0);
                    }
                    healItems["MedKit"] += 1;
                    tex.Dequeue();
                    med.Pop();
                }
                else if (sum > 100)
                {
                    if (!healItems.ContainsKey("MedKit"))
                    {
                        healItems.Add("MedKit", 0);
                    }
                    healItems["MedKit"] += 1;
                    int sumRemaining = tex.Dequeue() + med.Pop() - 100;
                    med.Push(med.Pop() + sumRemaining);
                }
                else 
                {
                    tex.Dequeue();
                    med.Push(med.Pop() + 10);

                }



            }
            if (tex.Count==0&&med.Count==0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if (tex.Count == 0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if (med.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }
            var healItemsOrdered = healItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in healItemsOrdered)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            if (tex.Count>0)
            {
                Console.WriteLine("Textiles left: "+String.Join(", ",tex));
            }
            if (med.Count > 0)
            {
                Console.WriteLine("Medicaments left: "+String.Join(", ", med));
            }
        }
    }
}
