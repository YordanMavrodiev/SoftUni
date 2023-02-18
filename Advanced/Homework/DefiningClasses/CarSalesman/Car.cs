using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "n/a";
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public Car()
        {

        }
        public Car()
        {

        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

    }
}
