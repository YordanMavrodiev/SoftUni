using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double single = 0;
            double reduce = 0;
            if (type == "Students" && day == "Friday") single = 8.45;
            if (type == "Students" && day == "Saturday") single = 9.80;
            if (type == "Students" && day == "Sunday") single = 10.46;
            if (type == "Business" && day == "Friday") single = 10.90;
            if (type == "Business" && day == "Saturday") single = 15.60;
            if (type == "Business" && day == "Sunday") single = 16;
            if (type == "Regular" && day == "Friday") single = 15;
            if (type == "Regular" && day == "Saturday") single = 20;
            if (type == "Regular" && day == "Sunday") single = 22.50;
            if (type == "Students" && ppl >= 30)
            {
                reduce = 0.15;
            }
            if (type == "Business" && ppl >= 100)
            {
                ppl -= 10;
            }
            if (type == "Regular" && ppl >= 10 && ppl <= 20)
            {
                reduce = 0.05;
            }
            double sum = ppl * single - ppl * single * reduce;
            Console.WriteLine("Total price: " + sum.ToString("F2"));

            
        }
    }
}
