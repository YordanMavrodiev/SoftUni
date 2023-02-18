using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] enter = Console.ReadLine().Split();
                Engine newengine = new Engine();
                if (enter.Length==2)
                {
                    newengine = new Engine(enter[0], int.Parse(enter[1]));
                }
                if (enter.Length == 3)
                {
                    newengine = new Engine(enter[0], int.Parse(enter[1]), int.Parse(enter[2]));
                }
                if (enter.Length == 4)
                {
                    newengine = new Engine(enter[0], int.Parse(enter[1]), int.Parse(enter[2]), enter[3]);
                }

                engines.Add(newengine);

            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] enter = Console.ReadLine().Split();
                string engineche = enter[1];
                Engine theengine =new Engine();
                foreach (var engine in engines)
                {
                    if (engineche==engine.Model)
                    {
                        theengine = engine;
                    }
                }
                Car newcar = new Car(enter[0],theengine, int.Parse(enter[2]), enter[3]);
                cars.Add(newcar);

            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}: \n  {car.Engine.Model}: \n    Power: {car.Engine.Power} \n    Displacement: {car.Engine.Displacement} \n    Efficiency: {car.Engine.Efficiency} \n  Weight: {car.Weight} \n  Color: {car.Color}"); 

            }
        }
    }
}
