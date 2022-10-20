using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string insert = Console.ReadLine();
            double sum = 0;

            while (insert!="Start")
            {
                if (double.Parse(insert)==0.1|| double.Parse(insert) == 0.2 || double.Parse(insert) == 0.5 || double.Parse(insert) == 1 || double.Parse(insert) == 2)
                {
                    sum += double.Parse(insert);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insert}");
                }
                insert = Console.ReadLine();
            }
            while (insert!="End")
            {
                insert = Console.ReadLine();
                if (insert=="End")
                {
                    continue;
                }
                if (insert=="Nuts")
                {
                    if (sum>=2.0)
                    {
                        Console.WriteLine("Purchased nuts");
                        sum -= 2;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (insert == "Water")
                {
                    if (sum >= 0.7)
                    {
                        Console.WriteLine("Purchased water");
                        sum -= 0.7;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (insert == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        sum -= 1.5;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (insert == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        Console.WriteLine("Purchased soda");
                        sum -= 0.8;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (insert == "Coke")
                {
                    if (sum >= 1)
                    {
                        Console.WriteLine("Purchased coke");
                        sum -= 1;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else 
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {sum.ToString("f2")}");
        }
    }
}
