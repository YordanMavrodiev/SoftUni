using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        const double DefaultFuelConsumption = 1.25;
        private double fuel;
        private int horsePower;

        public Vehicle(int horsePower,double fuel )
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public virtual void Drive(double kilometers)
        {
            if (Fuel - (FuelConsumption * kilometers) >= 0)
            {
                Fuel -= FuelConsumption * kilometers;
            }
        }


    }
}
