using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countOfPeople= int.Parse(Console.ReadLine());
            double energyLevel = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double totalwater = days * countOfPeople * water;
            double totalfood = days * countOfPeople * food;
            int count = 0;
            for (int i = 1; i <= days; i++)
            {
                double lostenergy = double.Parse(Console.ReadLine());
                energyLevel -= lostenergy;
                if (energyLevel<=0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalfood:f2} food and {totalwater:f2} water.");
                    break;
                }
                count++;
                if (count%2==0)
                {
                    energyLevel = energyLevel + 0.05 * energyLevel;
                    totalwater = totalwater - 0.30 * totalwater;
                }
                if (count % 3 == 0)
                {
                    energyLevel = energyLevel + 0.10 * energyLevel;
                    totalfood = totalfood - totalfood/countOfPeople;
                }
            }
            if (energyLevel>0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyLevel:F2} energy!");
            }
            
        }
    }
}
