using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] car = Console.ReadLine().Split(">>").ToArray();
            string[] empty = new string[3];
            double totalpay = 0;
            for (int i = 0; i < car.Length; i++)
            {
                
                double sum = 0;
                empty = car[i].Split(' ').ToArray();
                if (empty[0]=="family")
                {
                    sum = int.Parse(empty[2]) / 3000 * 12 + (50 - int.Parse(empty[1]) * 5);
                    totalpay += sum;
                    Console.WriteLine($"A {empty[0]} car will pay {sum:f2} euros in taxes.");
                    continue;
                }
                else if (empty[0] == "heavyDuty")
                {
                    sum = int.Parse(empty[2]) / 9000 * 14 + (80 - int.Parse(empty[1]) * 8);
                    totalpay += sum;
                    Console.WriteLine($"A {empty[0]} car will pay {sum:f2} euros in taxes.");
                    continue;
                }
                else if (empty[0] == "sports")
                {
                    sum = int.Parse(empty[2]) / 2000 * 18 + (100 - int.Parse(empty[1]) * 9);
                    totalpay += sum;
                    Console.WriteLine($"A {empty[0]} car will pay {sum:f2} euros in taxes.");
                    continue;
                }
                else Console.WriteLine("Invalid car type.");
                
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalpay:f2} euros in taxes.");
        }
    }
}
