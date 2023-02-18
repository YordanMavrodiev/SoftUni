using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public Car()
        {
            TravelledDistance = 0;
        }
        public Car(string model, double fuelAmount, double fuelConsumption) :this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
        }
        public void Drive(Car car, double km)
        {
            if (car.FuelConsumptionPerKilometer * km > car.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else 
            {
                car.FuelAmount -= car.FuelConsumptionPerKilometer * km;
                car.TravelledDistance += km;
            }
        
        }
    }
}
