using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] whiteTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] greyTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> whiteT = new Stack<int>();
            Queue<int> greyT = new Queue<int>();
            Dictionary<string, int> tilesMath = new Dictionary<string, int>();
            for (int i = 0; i < whiteTiles.Length; i++)
            {
                whiteT.Push(whiteTiles[i]);
            }
            for (int i = 0; i < greyTiles.Length; i++)
            {
                greyT.Enqueue(greyTiles[i]);
            }
            while (whiteT.Count>0&&greyT.Count>0)
            {
                if (greyT.Peek() == whiteT.Peek())
                {
                    int newTile = greyT.Dequeue() + whiteT.Pop();
                    if (newTile == 40)
                    {
                        if (!tilesMath.ContainsKey("Sink"))
                        {
                            tilesMath.Add("Sink", 0);
                        }
                        tilesMath["Sink"] += 1;
                    }
                    else if (newTile == 50)
                    {
                        if (!tilesMath.ContainsKey("Oven"))
                        {
                            tilesMath.Add("Oven", 0);
                        }
                        tilesMath["Oven"] += 1;
                    }
                    else if (newTile == 60)
                    {
                        if (!tilesMath.ContainsKey("Countertop"))
                        {
                            tilesMath.Add("Countertop", 0);
                        }
                        tilesMath["Countertop"] += 1;
                    }
                    else if (newTile == 70)
                    {
                        if (!tilesMath.ContainsKey("Wall"))
                        {
                            tilesMath.Add("Wall", 0);
                        }
                        tilesMath["Wall"] += 1;
                    }
                    else
                    {
                        if (!tilesMath.ContainsKey("Floor"))
                        {
                            tilesMath.Add("Floor", 0);
                        }
                        tilesMath["Floor"] += 1;

                    }

                }
                else
                {
                    whiteT.Push(whiteT.Pop() / 2);
                    greyT.Enqueue(greyT.Dequeue());


                }
            }
            if (whiteT.Count == 0)
            {
                Console.WriteLine("White tiles left: none");

            }
            else 
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",whiteT)}");
                
            }
            if (greyT.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");

            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyT)}");

            }
            var orderedTiles = tilesMath.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var tile in orderedTiles)
            {
                Console.WriteLine($"{tile.Key}: {tile.Value}");
            }
        }
    }
}
