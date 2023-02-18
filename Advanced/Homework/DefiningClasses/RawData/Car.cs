using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, int speed,int power, string type,int weight, float press1,int age1, float press2, int age2, float press3, int age3, float press4, int age4)
        {
            this.Tires = new List<Tires>();
            this.Engine = new Engine(speed,power);
            this.Cargo = new Cargo(type,weight);
            Model = model;
            Tires.Add(new Tires(age1, press1));
            Tires.Add(new Tires(age2, press2));
            Tires.Add(new Tires(age3, press3));
            Tires.Add(new Tires(age4, press4));
            


        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tires> Tires { get; set; }
    }
}
