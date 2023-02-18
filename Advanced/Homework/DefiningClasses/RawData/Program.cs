using System;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] enter = Console.ReadLine().Split();
                
                Car newcar = new Car(
                    enter[0],
                    int.Parse(enter[1]), int.Parse(enter[2]),
                    enter[4], int.Parse(enter[3]),
                    float.Parse(enter[5]),
                    int.Parse(enter[6]),
                    float.Parse(enter[7]),
                    int.Parse(enter[8]), 
                    float.Parse(enter[9]),
                    int.Parse(enter[10]), 
                    float.Parse(enter[11]),
                    int.Parse(enter[12])
                    );
                cars.Add(newcar);
                
            }
            string command = Console.ReadLine();
            if (command=="fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type== "fragile" && car.Tires[0].Pressure<1|| car.Cargo.Type == "fragile" && car.Tires[1].Pressure < 1 || car.Cargo.Type == "fragile" && car.Tires[2].Pressure < 1 || car.Cargo.Type == "fragile" && car.Tires[3].Pressure < 1)
                    {
                        Console.WriteLine(car.Model);
                    }
                    
                }
            }
            if (command== "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250 || car.Cargo.Type == "flammable" && car.Engine.Power > 250 || car.Cargo.Type == "flammable" && car.Engine.Power > 250 || car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }

                }
            }
        }
    }
}
