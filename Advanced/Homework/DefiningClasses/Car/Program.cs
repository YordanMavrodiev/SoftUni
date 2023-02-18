using System;
using System.Collections.Generic;

namespace Car
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split();
                Car newcar = new Car();
                newcar.Model = car[0];
                newcar.FuelAmount = double.Parse(car[1]);
                newcar.FuelConsumptionPerKilometer = double.Parse(car[2]);
                cars.Add(newcar);
            }
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                foreach (var car in cars)
                {
                    if (command[1] == car.Model)
                    {
                        car.Drive(car, double.Parse(command[2]));
                    }
                }
                command = Console.ReadLine().Split();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
